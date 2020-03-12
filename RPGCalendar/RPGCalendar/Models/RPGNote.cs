using System;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Models
{
    /*
     * Notes
3.1.1	Description and Priority
Notes are a Game Object (see 3.9) that are displayed on a Notes page. Notes are 
created with Title, Text, and Date fields. The Date field is optional. Both Game 
Master users and Player users can create notes and associate them with other Player 
users. A Player user can delete notes that they have created. A Game Master user 
can delete any notes.

3.1.2	Stimulus/Response Sequences
A Player user creates a note using a Title and chosen text. The note is viable to 
that Player user and the Game Master user.

A Player user creates a note using chosen Title, Text and Date, then associates it
with another Player user. The Note is visible to both Player users and the Game 
Master user. The Date field is viable on that note. 

A Game Master Player user creates a note using chosen Title, Text and Date, then 
associates it with a Player user. The Note is visible to that Player user and the 
Game Master user.

3.1.3	Functional Requirements

REQ-1:	A Player user shall be able to create a Note with a Title, Text, and a 
Date. The Date uses the current game’s calendar. Title and Text are required, but
the Date is optional. The Player user is associated with the Note.

REQ-2:	A Game Master user shall be able to create a Note with a Title, Text, and 
a Date. The Date uses the current game’s calendar. Title and Text are required, 
but the Date is optional. 

REQ-3:	Player users and Game Master users have create permissions. 

REQ-4:	Players users who create a Note have read, update, and delete permissions. 

REQ-5:	Players users who are associated with the Note have read permissions.

REQ-6:	Game Master users have read, update, and delete permissions.
     */
    public class RPGNote : GameObject
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
