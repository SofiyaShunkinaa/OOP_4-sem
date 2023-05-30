using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using EF_lr9.Flower;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace EF_lr9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        FlowerContext db;
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                db = new FlowerContext();
                db.Flowers.Load(); // загружаем данные
                flowersGrid.ItemsSource = db.Flowers.Local.ToBindingList(); // устанавливаем привязку к кэшу

                this.Closing += MainWindow_Closing;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (flowersGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < flowersGrid.SelectedItems.Count; i++)
                {
                    Flower flower = flowersGrid.SelectedItems[i] as Flower;
                    if (flower != null)
                    {
                        db.Flowers.Remove(flower);
                    }
                }
            }
            db.SaveChanges();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((TitleTextBox.Text != "") || (FamilyTextBox.Text != "") || (PriceTextBox.Text != ""))
                {
                    if (Convert.ToInt32(PriceTextBox.Text) > 0)
                    {
                        Flower flower = flowersGrid.SelectedItem as Flower;
                        Flower flowerForCopy = new Flower();


                        if (flower != null)
                        {
                            flowerForCopy = flower;
                            db.Flowers.Remove(flower);
                        }

                        flowerForCopy.Title = TitleTextBox.Text;
                        flowerForCopy.Family = FamilyTextBox.Text;
                        flowerForCopy.Price = Convert.ToInt32(PriceTextBox.Text);

                        db.Flowers.Add(flowerForCopy);
                        db.SaveChanges();
                        MessageBox.Show("Изменения сохранены!");

                        TitleTextBox.Text = "";
                        FamilyTextBox.Text = "";
                        PriceTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Введите положительную стоимость!");
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Flower flower = flowersGrid.SelectedItem as Flower;
                if (flower != null)
                {
                    TitleTextBox.Text = flower.Title;
                    FamilyTextBox.Text = flower.Family;
                    PriceTextBox.Text = Convert.ToString(flower.Price);
                }
                else
                {
                    MessageBox.Show("Попробуйте еще раз!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message, ex);
            }



        }

        private void SortingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                if (SortingComboBox.SelectedIndex == 0)
                {
                
                try
                    {
                    FilterListBox.Items.Clear();
                    using (FlowerContext db1 = new FlowerContext())
                        {
                            var res = (from p in db.Flowers orderby p.Price select p);
                            foreach(var f in res)
                            {
                                FilterListBox.Items.Add("Название: " + f.Title + ", Семейство: " + ", Цена: " + f.Price);
                            }
                        }
                }
                    catch(Exception ex) { Console.WriteLine(ex.Message); }
                    
                }
            if (SortingComboBox.SelectedIndex == 1)
            {

                try
                {
                    FilterListBox.Items.Clear();
                    using (FlowerContext db1 = new FlowerContext())
                    {
                        var res = (from p in db.Flowers orderby p.Price descending select p);
                        foreach (var f in res)
                        {
                            FilterListBox.Items.Add("Название: " + f.Title + ", Семейство: " + ", Цена: " + f.Price);
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if((FamilyTextBoxSearch.Text == "")&(TitleTextBoxSearch.Text != "")){
                try
                {
                    FilterListBox.Items.Clear();
                    using (FlowerContext db1 = new FlowerContext())
                    {
                        var res = (from p in db.Flowers select p);
                        Regex regex = new Regex(TitleTextBoxSearch.Text);
                        MatchCollection matchFlowerTitle;

                        foreach (var f in res)
                        {
                            matchFlowerTitle = regex.Matches(f.Title);
                            if (matchFlowerTitle.Count > 0)
                            {
                                foreach (Match match in matchFlowerTitle)
                                    FilterListBox.Items.Add("Название: " + f.Title + ", Семейство: " + f.Family + ", Цена: " + f.Price);
                            }
                            
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }     
            }
            if ((FamilyTextBoxSearch.Text != "") & (TitleTextBoxSearch.Text == ""))
            {
                try
                {
                    FilterListBox.Items.Clear();
                    using (FlowerContext db1 = new FlowerContext())
                    {
                        var res = (from p in db.Flowers select p);
                        Regex regex = new Regex(FamilyTextBoxSearch.Text);
                        MatchCollection matchFlowerTitle;

                        foreach (var f in res)
                        {
                            matchFlowerTitle = regex.Matches(f.Family);
                            if (matchFlowerTitle.Count > 0)
                            {
                                foreach (Match match in matchFlowerTitle)
                                    FilterListBox.Items.Add("Название: " + f.Title + ", Семейство: " + f.Family + ", Цена: " + f.Price);
                            }

                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            if ((FamilyTextBoxSearch.Text != "") & (TitleTextBoxSearch.Text != ""))
            {
                try
                {
                    FilterListBox.Items.Clear();
                    using (FlowerContext db1 = new FlowerContext())
                    {
                        var res = (from p in db.Flowers select p);
                        Regex regex = new Regex(FamilyTextBoxSearch.Text);
                        Regex regex1 = new Regex(TitleTextBoxSearch.Text);
                        MatchCollection matchFlowerTitle;
                        MatchCollection matchFlowerFamily;

                        foreach (var f in res)
                        {
                            matchFlowerTitle = regex.Matches(f.Title);
                            matchFlowerFamily = regex.Matches(f.Family);
                            if ((matchFlowerTitle.Count > 0)&(matchFlowerFamily.Count > 0))
                            {
                               
                                        foreach (Match match in matchFlowerFamily)
                                            FilterListBox.Items.Add("Название: " + f.Title + ", Семейство: " + f.Family + ", Цена: " + f.Price);
                                    
                               
                            }

                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        private void AsyncBtn_Click(object sender, RoutedEventArgs e)
        {
            var task = PerformDatabaseOperations();
            MessageBox.Show("Цитата дня");
            MessageBox.Show("Не переживай о том, что наступит конец дня...");
            MessageBox.Show("В Австралии это всегда завтра.");

            task.Wait();

        }

        public static async Task PerformDatabaseOperations()
        {
            using (var db1 = new FlowerContext())
            {
                // Create a new blog and save it
                db1.Flowers.Add(new Flower
                {
                    Title = "Test async" + (db1.Flowers.Count() + 1)
                });
                MessageBox.Show("Calling SaveChanges.");
                await db1.SaveChangesAsync();
                MessageBox.Show("SaveChanges completed.");

                // Query for all blogs ordered by name
                MessageBox.Show("Executing query.");
                var flows = await (from b in db1.Flowers
                                   orderby b.Title
                                   select b).ToListAsync();

                // Write all blogs out to Console
                MessageBox.Show("Query completed with following results:");
                foreach (var flow in flows)
                {
                    MessageBox.Show(" - " + flow.Title);
                }
            }
        }

        private void SyncBtn_Click(object sender, RoutedEventArgs e)
        {
            PerformDatabaseOperationsSync();
            MessageBox.Show("Цитата дня");
            MessageBox.Show("Не переживай о том, что наступит конец дня...");
            MessageBox.Show("В Австралии это всегда завтра.");

        }
        public static void PerformDatabaseOperationsSync()
        {
            using (var db2 = new FlowerContext())
            {
                // Create a new blog and save it
                db2.Flowers.Add(new Flower
                {
                    Title = "Test Sync" + (db2.Flowers.Count() + 1)
                });
                MessageBox.Show("Calling SaveChanges.");
                db2.SaveChanges();
                MessageBox.Show("SaveChanges completed.");

                // Query for all blogs ordered by name
                MessageBox.Show("Executing query.");
                var flows = (from b in db2.Flowers
                             orderby b.Title
                             select b).ToList();

                // Write all blogs out to Console
                MessageBox.Show("Query completed with following results:");
                foreach (var flow in flows)
                {
                    MessageBox.Show(" " + flow.Title);
                }
            }
        }
        public void Vyborka()
        {
            var vyborka = db.Database.SqlQuery<Flower>("SELECT * FROM Flowers");
        }
        public void SearchWithTransact()
        {
            
                using (var db1 = new FlowerContext())
                {
                    using(var transaction = db1.Database.BeginTransaction()){
                    try
                    {
                        Flower fl = db1.Flowers.FirstOrDefault(p => p.Title == "Алоэ");
                        FilterListBox.Items.Add(fl);
                        db1.SaveChanges();
                        
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
