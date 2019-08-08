using System;
using System.ComponentModel.DataAnnotations;

namespace WebPortalUI.Models.EntityDataModel
{
    public class SYSUserRole
    {
        [Key]
        public int SYSUserRoleID { get; set; }
        public int SYSUserID { get; set; }
        public int LOOKUPRoleID { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedUserID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int ModifiedUserID { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}