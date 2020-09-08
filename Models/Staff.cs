using System.ComponentModel.DataAnnotations;

namespace Attendance.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }


    }
}
