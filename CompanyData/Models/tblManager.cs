//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyData.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblManager
    {
        public int ManagerID { get; set; }
        public int UserDataID { get; set; }
        public Nullable<int> LevelOfResponsibility { get; set; }
        public string PasswordHint { get; set; }
        public string Email { get; set; }
        public string OfficeNumber { get; set; }
        public string ProjectsCount { get; set; }
        public Nullable<decimal> Salary { get; set; }
    
        public virtual tblUserData tblUserData { get; set; }
    }
}