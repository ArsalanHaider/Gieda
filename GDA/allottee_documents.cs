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
    
    public partial class allottee_documents
    {
        public int id { get; set; }
        public string title { get; set; }
        public string document { get; set; }
        public int allotee_id { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        public virtual allottee allottee { get; set; }
    }
}
