//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int ID { get; set; }
        public int ProviderID { get; set; }
        public int ServiceID { get; set; }
        public int Hide { get; set; }
        public List<int> SelectedService { get; set; }


        public virtual Provider Provider { get; set; }
        public virtual ListOfService ListOfService { get; set; }
    }
}
