using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/*
 Game Objects

3.1.1	Description and Priority
A Game Object is an entity that is created for and inside a game. 
The game objects are Events, Items, Notes and Notifications (see below). 
Objects can be associated with one or more Player users. 
Game objects have a permissions quality that allows users to create, read, update or delete an object.
A Game Master user has full permissions, where a Player user may have permission limited to objects associated to them.

3.1.2	Stimulus/Response Sequences
A user attempts to create, read, update or delete an object; 
the action is performed only if the user has permission to that object. 
A Player user creates a new Item; that item is associated to that Player.

A Game Master creates an Event and associates it to a Player. That Player may now read that event.
3.1.3	Functional Requirements

REQ-1:	Users shall only create, read, update or delete objects for which they have permissions to do so. 

REQ-2:	Player users shall only have permissions for objects which they are associated. 

REQ-3:	Objects shall be able to be associated to Players.

     */
namespace RPGCalendar.Models
{
    public class GameObject : FingerPrintEntityBase
    {
        [Required]
        string GameId { get; internal set; }
        [Required]
        string Permission { get; internal set; }
    }
}
