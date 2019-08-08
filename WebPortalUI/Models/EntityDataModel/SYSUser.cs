using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPortalUI.Models.EntityDataModel
{
    [Table("SYSUser")]
    public class SYSUser
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SYSUserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordEncryptedText { get; set; }
        public int CreatedUserID { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int ModifiedUserID { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}