﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? BirthDate { get; set; }

        //[Min18YearsIsAMember]
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }
    }
}