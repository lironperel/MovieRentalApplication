//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieRentalApplication.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            this.RentedMovies = new HashSet<RentedMovie>();
        }
        [Key]
        [DisplayName("Movie ID")]
        public int movieID { get; set; }

        [DisplayName("Movie Title")]
        [RegularExpression(@"^[!-~ ]+$", ErrorMessage = "Movie title error - invaild characters")]
        public string movieName { get; set; }

        [DisplayName("Year")]
        [RegularExpression(@"^(19|20)\d{2}$", ErrorMessage = "Year error - please enter value between 1900-2099")]
        public short year { get; set; }

        [DisplayName("Image")]
        public byte[] image { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        [StringLength(1000,ErrorMessage = "Description must be 1000 chars maximum")]
        public string description { get; set; }

        [DisplayName("Genre")]
        [StringLength(20, ErrorMessage = "Genre should be 20 chars maximum")]
        public string genre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentedMovie> RentedMovies { get; set; }
    }
}