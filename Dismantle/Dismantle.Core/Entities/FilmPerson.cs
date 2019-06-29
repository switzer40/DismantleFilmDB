using Dismantle.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dismantle.Core.Entities
{
    public class FilmPerson : BaseEntity
    {
        public FilmPerson()
        {
        }
        public FilmPerson(int filmId, int personId, string role)
        {
            FilmId = filmId;
            PersonId = personId;
            Role = role;
        }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        public string Role { get; set; }
        public virtual Film Film { get; set; }
        public virtual Person Person { get; set; }

        public override void Copy(BaseEntity e)
        {
            if (e.GetType() == typeof(FilmPerson))
            {
                var that = (FilmPerson)e;
                FilmId = that.FilmId;
                PersonId = that.PersonId;
                Role = that.Role;
            }
        }

        public override bool Equals(BaseEntity other)
        {
            bool result = false;
            if (other.GetType() == typeof(FilmPerson))
            {
                var that = (FilmPerson)other;
                result = (FilmId == that.FilmId) &&
                         (PersonId == that.PersonId) &&
                         (Role.Equals(that.Role));
            }
            return result;
        }

        public override bool Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
