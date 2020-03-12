using System;
using System.ComponentModel.DataAnnotations;

namespace RPGCalendar.Models
{
    /*
     * Notifications
3.1.1	Description and Priority
Notifications are a Game Object (see 3.9) that are displayed on the Notification
view. Notifications have a Title and Description field. Notifications are created 
by Event (see 3.10). Associated Player users have the ability to read and delete 
notifications. Game Master users may read and delete any notifications.

3.1.2	Stimulus/Response Sequences
An Event triggers a Notification to be created. The Notification is displayed to 
the Player users associated with the Event. 

3.1.3	Functional Requirements

REQ-1:	A Notification shall be created by an Event if it has at least 1 associated
Player user. The contents of the Notification mirror the Event.

REQ-2:	A Player user associated with a Notification shall have read and delete 
permissions.

REQ-3:	A Game Master user shall have read and delete permissions.
     */
    public class RPGNotification
    {
        [Required]
        public string Title { get; internal set; }
        [Required]
        public string Description { get; internal set; }

    }
}
