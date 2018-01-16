using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0, floor, closet_door, corridor_1, stairs_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard};
	private States myState;

	// Use this for initialization
	void Start () 
	{
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		if (myState == States.cell) {
			cell ();
		} else if (myState == States.sheets_0) {
			sheets_0 ();
		} else if (myState == States.mirror) {
			mirror ();
		} else if (myState == States.lock_0) {
			lock_0 ();
		} else if (myState == States.cell_mirror) {
			cell_mirror ();
		} else if (myState == States.sheets_1) {
			sheets_1 ();
		} else if (myState == States.lock_1) {
			lock_1 ();
		} else if (myState == States.corridor_0) {
			corridor_0 ();
		} else if (myState == States.stairs_0) {
			stairs_0 ();
		} else if (myState == States.floor) {
			floor ();
		} else if (myState == States.closet_door) {
			closet_door ();
		} else if (myState == States.corridor_1) {
			corridor_1 ();
		} else if (myState == States.stairs_1) {
			stairs_1 ();
		} else if (myState == States.in_closet) {
			in_closet ();
		} else if (myState == States.corridor_2) {
			corridor_2 ();
		} else if (myState == States.stairs_2) {
			stairs_2 ();
		} else if (myState == States.corridor_3) {
			corridor_3 ();
		} else if (myState == States.courtyard) {
			courtyard ();
		}

			// else
			// corridor_0 ();
	}

	#region State handler methods
	//first tier
	void cell ()
	{
		text.text = "This is the Dawning of the Age of Aquarius, Age of Aquarius... Aquarius!  Aquarius!   Harmony and Understanding.  Sympathy and Trust Abounding. No more falsehoods and derisions. " +
		"Golden living dreams of visions Mystic crystal revelation And the mind's true liberation Aquarius! Aquarius!\n\n" +
		"You wake up in a prison cell and you want to escape. There are some dirty sheets on the bed, a mirror on the wall, and the door is locked from the outside.\n\n" +
		"Press S to view Sheets, M to view Mirror, and L to view the door lock.";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		} 
		
	}

	void sheets_0 ()
	{
		text.text = "You can't believe you sleep in these things.  Surely it's time somebody changed them.  The pleasures of prison life, I guess!\n\n" +
		"Press R to Return to roaming your cell. ";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;

		}
	}
	// continue editing script below
	void mirror ()
	{
		text.text = "You regard yourself in the mirror and the mirror says you're ugly.  Then the cheeky mirror shatters itself into a million pieces.\n\n" +
					"Press T to take a shard of broken mirror, or R to Return to roaming your cell.";
		
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}

	void lock_0 ()
	{
		text.text = "You take a look at the door lock and it is a standard key operated type.  But you obviously don't have the key.  You can't do anything" +
					"with the lock at the moment.\n\n" +  
					"Press R to Return to roaming your cell. ";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}
	// second tier 
	void cell_mirror ()
	{
		text.text = "You sift through the broken mirror shards to find piece that may be suitable for picking a lock.  You find a few halfway promising candidates.\n\n" +
		"Press S to rummage through the sheets again, or L to take a second look at the door lock.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	}

	void sheets_1 ()
	{
		text.text = "You rummage through the dirty sheets and find nothing useful.\n\n" +
		"Press R to turn your attention back to the broken mirror. ";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;

		}
	}

	void lock_1 ()
	{
		text.text = "You take one look at the door lock and one look at the broken mirror shards in your hand.  Surely one would be a fool to think you can pick a door lock " +
					"with a broken mirror.  But then again, never say never.\n\n" +
					"Press R to turn your attention back to the broken mirror, or press L to try your hand at picking the door lock.";		
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;

		}	else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.corridor_0;
		}
	}

	void corridor_0 () 
	{
		text.text = "You spend hours trying to pick the lock with about a dozen broken mirror shards.  Finally, when you are just about at your wits end, the umpteenth" +
		 			"mirror shard somehow causes the door lock to disengage with a surprising click. You open the door and hurry out to the corridor." +
		 			"You see a stairway going up and a closet door.\n\n" +
		 			"Press S to take the stairs, F to examine the floor, or C to open the closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.floor;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.closet_door;
		}
	}
	//third tier (stage 2)
	void floor () 
	{
		text.text = "You look at the tiled floor which could use a bit of cleaning and waxing.  There is nothing particularly remarkable about the tile floor. " +
		 			"But just as your attention starts to wander, you catch a glimpse of a hairpin off to the side, where the wall meets the floor.\n\n" +
		 			"Press T to take the hairclip, or R to stop staring at the floor.";
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.corridor_1;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}

	void stairs_0 () 
	{
		text.text = "You tiptoe carefully up the stairs and see a set of double doors leading outside.  You peer carefully through the glass pane and realize that there " +
		 			"are guards patrolling everywhere. Making a run for it outside is obviously not a good idea at this point. You need to rethink this.\n\n" +
		 			"Press S to go back down the stairs.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.corridor_0;
		}
	}

	void closet_door () 
	{
		text.text = "The closet door is locked.  You can't get inside.\n\n" +
		 			"Press R to return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;

		}
	}
	//fourth tier (stage 2)
	void corridor_1 () 
	{
		text.text = "Alright, so you are armed with a dingy hairclip. You see a stairway going up and a closet door.\n\n" +
		 			"Press S to take the stairs, or C to open the closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_1;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.in_closet;
		}
	}

	void stairs_1 () 
	{
		text.text = "You tiptoe carefully up the stairs and see a set of double doors leading outside. Armed with only a hairclip, you chances of making a dash for freedom outside is still nil. You need to rethink this again.\n\n" +
		 			"Press S to go back down the stairs.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.corridor_1;
		}
	}

	void in_closet () 
	{
		text.text = "Bravo! So you get the bright idea to pick the closet keyhole with the hairpin.  After a bit of fumbling, the closet door unlocks. You peer inside and find a complete janitor's outfit.\n\n" +
		 			"Press R to return to the corridor, or D to wear the janitor's outfit.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_1;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.corridor_3;
		}
	}
	//fifth tier (stage 2)
	void corridor_2 () 
	{
		text.text = "You spend hours trying to pick the lock with about a dozen broken mirror shards.  Finally, when you are just about at your wits end, the umpteenth" +
		 			"mirror shard somehow causes the door lock to disengage with a surprising click. You open the door and hurry out to the corridor." +
		 			"You see a stairway going up and a closet door.\n\n" +
		 			"Press S to take the stairs, F to examine the floor, or C to open the closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;

		}
	}

	void stairs_2 () 
	{
		text.text = "You spend hours trying to pick the lock with about a dozen broken mirror shards.  Finally, when you are just about at your wits end, the umpteenth" +
		 			"mirror shard somehow causes the door lock to disengage with a surprising click. You open the door and hurry out to the corridor." +
		 			"You see a stairway going up and a closet door.\n\n" +
		 			"Press S to take the stairs, F to examine the floor, or C to open the closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;

		}
	}

	//sixth tier (stage 2)
	void corridor_3 () 
	{
		text.text = "You are back in the corridor.  Now it would make sense to make a dash for the stairs.\n\n" +
		 			"Press S to take the stairway.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.courtyard;

		}
	}

	void courtyard () 
	{
		text.text = "You ascend the stairs, take a deep breath and exhale to calm yourself, and you step out cautiously to the outside world.  You approach the outer security checkpoint and the guards barely take any notice of you. " +
		 			"You casually saunter down a few blocks away from the prison compound, to Freedom!\n\n" +
		 			"Press P if you wish to Play again.";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;

		}
	}
}
#endregion