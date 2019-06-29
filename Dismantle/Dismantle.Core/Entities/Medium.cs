using Dismantle.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dismantle.Core.Entities
{
    public class Medium : BaseEntity
    {
        public Medium()
        {
        }
        public Medium(int filmId, string mediumType, string location = "", bool hasGermanSubtitles = true)
        {
            FilmId = filmId;
            MediumType = mediumType;
            Location = location;
            HasGermanSubtitles = hasGermanSubtitles;
        }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public string MediumType { get; set; }
        public string Location { get; set; }
        public bool HasGermanSubtitles { get; set; }
        public virtual Film Film { get; set; }

        public override void Copy(BaseEntity e)
        {
            if (e.GetType() == typeof(Medium))
            {
                var that = (Medium)e;
                FilmId = that.FilmId;
                MediumType = that.MediumType;
                Location = that.Location;
                HasGermanSubtitles = that.HasGermanSubtitles;
            }
        }

        public override bool Equals(BaseEntity other)
        {
            bool result = false;
            if (other.GetType() == typeof(Medium))
            {
                var that = (Medium)other;
                result = (FilmId == that.FilmId) &&
                        (MediumType.Equals(that.MediumType)) &&
                        (Location == that.Location) &&
                        (HasGermanSubtitles == that.HasGermanSubtitles);
            }
            return result;
        }

        public override bool Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
