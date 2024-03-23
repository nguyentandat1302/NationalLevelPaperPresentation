namespace NationalLevelPaperPresentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Participant")]
    public partial class Participant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Participant()
        {
            Activity = new HashSet<Activity>();
            User = new HashSet<User>();
        }

        [Key]
        public int participant_id { get; set; }

        [Required(ErrorMessage = "Name không được đỡ trống")]
        [StringLength(50)]
        public string name { get; set; }

        [Required(ErrorMessage = "Email không được đỡ trống")]
        [StringLength(50)]
        public string email { get; set; }

        
        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
        public bool? payment_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}
