//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlaneImage
    {
        public int Id { get; set; }
        public int PalneId { get; set; }
        public byte[] ImageSource { get; set; }
        public string ImageLink { get; set; }
    
        public virtual Plane Plane { get; set; }
    }
}