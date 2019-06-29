using Dismantle.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dismantle.Core.Entities
{
    public class Film : BaseEntity
    {
        public Film()
        {
        }
        public Film(string title, short year, short length = 10)
        {
            Title = title;
            Year = year;
            Length = length;
            FilmPeople = new List<FilmPerson>();
            Media = new List<Medium>();
        }
        [Required]
        public string Title { get; set; }
        [Required]
        public short Year { get; set; }
        public short Length { get; set; }
        public virtual List<FilmPerson> FilmPeople { get; set; }
        public virtual List<Medium> Media { get; set; }

        public override void Copy(BaseEntity e)
        {
            if (e.GetType() == typeof(Film))
            {
                var that = (Film)e;
                Title = that.Title;
                Year = that.Year;
                Length = that.Length;
            }
        }

        public override bool Equals(BaseEntity e)
        {
            bool result = false;
            if (e.GetType() == typeof(Film))
            {
                var that = (Film)e;
                result = (Title.Equals(that.Title)) &&
                        (Year == that.Year) &&
                        (Length == that.Length);
            }
            return result;
        }

        public override bool Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
