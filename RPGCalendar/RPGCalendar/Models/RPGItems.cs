using System;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Models
{
    /*
     * Items
3.1.1	Description and Priority
Items are a Game Object (see 3.9) that appears on the Player List (see 3.8). Items 
have the following properties: Name, Description, Quantity, Quality, Quantity 
Degradation, Quality Degradation. 

Items are created by specifying the above; Quantity is an integer, Quality is a 
decimal, Quantity Degradation is an integer/time, and Quality degradation is an 
amount/time.

If a Game Master selects to have Items be affected by time (see 3.7), the Item’s 
quantity and quality degrade by the amount specified. 


3.1.2	Stimulus/Response Sequences
A Player user creates an Item using the values specified. The Item is visible in 
their Player list. 
A Game Master user creates an Item associated to a Player then advance the time. 
The Item’s quantity and quality values decrease. 

3.1.3	Functional Requirements

REQ-1:	A user shall be able to create an Item using Name, Description, Quantity, 
Quality, Quantity Degradation, Quality Degradation. The Item shall be associated 
to the Player that created it, or the specified Player if created by a Game Master
user.

REQ-2:	Items shall decrease in Quantity after the specified time. A ‘counter’ is 
held and compared to the elapsed time; if that counter exceeds the specified time, 
it decreases the quantity. Otherwise, the ‘counter’ is stored with the item. 

REQ-3:	Items shall decrease in Quality for each elapsed time. The amount decreased 
is always proportional to the specified degradation. (Example: Quality 5.0, Quality 
Degradation 2 / 1 day. If 0.5 days elapse, the quality is now 4.0)

REQ-4:	Game Masters user and Player users have create, read, update and delete 
privileges for Items. Players users are restricted to updating and deleting Items 
they are associated with.
     */
    public class RPGItems : GameObject
    {
        [Required]
        public string Name { get; internal set; }
        [Required]
        public string Description { get; internal set; }
        [Required]
        public double Quantity { get; internal set; }
        [Required]
        public double Quality { get; internal set; }
        [Required]
        public double QuanityDegration { get; internal set; }
        [Required]
        public double QualityDegration { get; internal set; }
        [Required]
        public string Player { get; internal set; }
    }
}
