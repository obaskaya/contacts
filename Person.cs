using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation;
namespace contacts
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? SurName {get; set;}
        public int? TelNum {get; set;}

    }
}