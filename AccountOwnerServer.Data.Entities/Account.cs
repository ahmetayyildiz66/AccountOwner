using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountOwnerServer.Data.Entities
{
    [Table("account")]
    public class Account: EntityBase<Guid>
    {

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }

        [Required(ErrorMessage = "Owner Id is required")]
        public Guid OwnerId { get; set; }
    }
}
