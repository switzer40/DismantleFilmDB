using Dismantle.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dismantle.Core.Entities
{
    public class Person : BaseEntity
    {
        public Person()
        {
        }
        public Person(string lastName,
                      string birthdate,
                      string firstMidName = "")
        {
            LastName = lastName;
            BirthdateString = birthdate;
            FirstMidName = firstMidName;
            FullName = $"{FirstMidName} {LastName}";
            Birthdate = DateTime.Parse(birthdate);
            FilmPeople = new List<FilmPerson>();
        }
        public string FirstMidName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BirthdateString { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public virtual List<FilmPerson> FilmPeople { get; set; }

        public override void Copy(BaseEntity e)
        {
            if (e.GetType() == typeof(Person))
            {
                var that = (Person)e;
                LastName = that.LastName;
                BirthdateString = that.BirthdateString;
                FirstMidName = that.FirstMidName;
                FullName = that.FullName;
                Birthdate = that.Birthdate;
            }
        }

        public override bool Equals(BaseEntity other)
        {
            bool result = false;
            if (other.GetType() == typeof(Person))
            {
                var that = (Person)other;
                result = (LastName.Equals(that.LastName)) &&
                         (FirstMidName.Equals(that.FirstMidName)) &&
                         (BirthdateString.Equals(that.BirthdateString));
            }
            return result;
        }

        public override bool Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
