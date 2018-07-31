using System;
using System.ComponentModel;

namespace GetSearchDemo.ViewModels
{
    public class PersonSearchModel
    {

        [DisplayName("Forename")]
        public string Forename { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [DisplayName("Date of birth")]
        public DateTime? DateOfBirth { get; set; }
      
    }
}

