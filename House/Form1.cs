using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;

        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        int Moves;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            moveToNewLocation(livingRoom);
            ResetGame(false);
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in: " + Moves + " moves.");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                descriptionBox.Text = "You found your opponent in " + Moves + "moves! He was hiding " +
                    foundLocation.HidingPlace + ".";
            }
            Moves = 0;
            hideButton.Visible = true;
            goButton.Visible = false;
            checkButton.Visible = false;
            doorButton.Visible = false;
            locationSelectionBox.Visible = false;
        }

        private void doorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            moveToNewLocation(hasDoor.DoorLocation);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            moveToNewLocation(currentLocation.Exits[locationSelectionBox.SelectedIndex]);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob", "inside the closet");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandalier", "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door", "in the cabinet");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and toilet", "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");


            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void moveToNewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            Moves++;
            RedrawForm();
        }

        private void RedrawForm()
        {
            locationSelectionBox.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                locationSelectionBox.Items.Add(currentLocation.Exits[i].Name);
            }
            locationSelectionBox.SelectedIndex = 0;
            descriptionBox.Text = currentLocation.Description + "\r\n(move #" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                checkButton.Text = "Check " + hidingPlace.HidingPlace;
                checkButton.Visible = true;
            }
            else
            {
                checkButton.Visible = false;
            }
            if(currentLocation is IHasExteriorDoor)
            {
                doorButton.Visible = true;
            }
            else
            {
                doorButton.Visible = false;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                descriptionBox.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }
            descriptionBox.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goButton.Visible = true;
            locationSelectionBox.Visible = true;
            moveToNewLocation(livingRoom);
        }
    }
}
