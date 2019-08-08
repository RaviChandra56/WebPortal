using System;
using System.ComponentModel.DataAnnotations;

namespace WebPortalUI.Models.EntityDataModel
{
    public class SYSUserProfile
    {
        [Key]
        public int SYSUserProfileID { get; set; }
        public int SYSUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int CreatedUserID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int ModifiedUserID { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}