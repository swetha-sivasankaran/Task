using System;
using System.Collections.Generic;

namespace Assignment.Contracts.Data.Entities
{
    public partial class User: BaseEntity
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? AddedOn { get; set; }
    }
}
