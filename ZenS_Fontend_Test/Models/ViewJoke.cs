//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZenS_Fontend_Test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewJoke
    {
        public int Id { get; set; }
        public int JokeId { get; set; }
        public System.DateTime ViewTime { get; set; }
        public Nullable<bool> Like { get; set; }
    
        public virtual Joke Joke { get; set; }
    }
}