using System.ComponentModel.DataAnnotations;

namespace RazorPage.Models {

    public class OrderPage {

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your quantity")]
        public string Address { get; set; }

        [Required(ErrorMessage = "What do you want to order")]
        public string Item { get; set; }
        
// BEGIN TRANSACTION;
// CREATE TABLE IF NOT EXISTS "Item" (
// 	"Name"	TEXT NOT NULL,
// 	"ID"	INTEGER NOT NULL,
// 	"Quantity"	INTEGER NOT NULL,
// 	"Price"	INTEGER NOT NULL,
// 	PRIMARY KEY("ID")
// );
// INSERT INTO "Item" VALUES ('Bread',1,100,'$1.00');
// INSERT INTO "Item" VALUES ('Eggs',2,100,'$0.99');
// INSERT INTO "Item" VALUES ('Cheese',3,50,'$0.99');
// INSERT INTO "Item" VALUES ('Milk',4,100,'$1.50');
// COMMIT;

    }
}