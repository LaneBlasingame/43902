using System.ComponentModel.DataAnnotations;

namespace RazorPage.Models {

    public class DeliveryPage {

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Will you accept the order")]
        public bool? OrderAccept { get; set; }
    }
}