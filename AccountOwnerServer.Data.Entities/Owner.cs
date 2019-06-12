using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountOwnerServer.Data.Entities
{
    [Table("owner")]
    public class Owner: EntityBase<Guid>
    {

        public Owner()
        {
            Accounts = new List<Account>();
        }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters.")]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Addres is required")]
        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
        public string Address { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

    }
}
