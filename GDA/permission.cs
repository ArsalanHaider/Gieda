//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class permission
    {
        public int id { get; set; }
        public string name { get; set; }
        public int roles_id { get; set; }
    
        public virtual role role { get; set; }
    }
}
