//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassActivity3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet
    {
        public int PetID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int VetID { get; set; }
    
        public virtual Vet Vet { get; set; }
    }
}
