using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Models
{
    /*
     * Events
3.1.1	Description and Priority
Events are a Game Object (see 3.9) that appear on the Game Calendar (see 3.7). 
Events are linked to a specific time on the Game Calendar. If the in-game time 
exceeds the event’s start time, then all Players who are associated with it 
receive a Notification (see 3.13). Events are normally visible to all associated 
Players unless the Surprise flag is true. Creating an Event requires a Title, 
Description, Start Time, End Time, Surprise and Player List 

3.1.2	Stimulus/Response Sequences
A Game Master user creates an Event and associates it with Players. The event
is visible on the Player’s Game Calendar and the Players receive Notification 
once the Game Master advance the time beyond the Event’s start time. 

A Game Master user creates an Event with the Surprise flag, then associates it 
with Players. The Event is only visible once the in-game time advances beyond the 
Event’s start time.  

3.1.3	Functional Requirements

REQ-1:	A Game Master user shall be able to create an Event using Title, 
Description, Start Time, End Time, Surprise and Player List.

REQ-2: 	A Player user shall be able to read all Events that they are associated 
with, unless that Event is marked as a surprise. Players users shall be able to 
read all surprise Events once the in-game time exceeds the Event’s start time. 

REQ-3:	A Game Master has create, read, update, and delete permissions. A Player 
only has read permissions (see REQ-2).
     */
    public class RPGEvent : GameObject
    {
        [Required]
        public string Title { get; internal set; }
        [Required]
        public string Description { get; internal set; }
        [Required]
        public DateTime StartTime { get; internal set; }
        [Required]
        public DateTime EndTime { get; internal set; }
        [Required]
        public bool Surprise { get; internal set; }
        [Required]
        public List<string> PlayerList { get; internal set; }

    }
}
