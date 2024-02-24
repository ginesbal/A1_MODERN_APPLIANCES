using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// --------------------------------------------------------------------------Option 1: Performs a checkout--------------------------------------------------------------------------
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance:");

            // Create long variable to hold item number
            long itemNumber = long.Parse(Console.ReadLine());
            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)

            Appliance foundAppliance = null;

            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }
            else
            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            {
                if (foundAppliance.IsAvailable)
                {


                    // Write "Appliance has been checked out."
                    foundAppliance.Checkout();
                    Console.WriteLine($"Appliance '{itemNumber}' has been checked out");
                }

                else
                // Otherwise (appliance isn't available)
                // Write "The appliance is not available to be checked out."
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        /// <summary>
        ///-------------------------------------------------------------------------- Option 2: Finds appliances--------------------------------------------------------------------------
        /// </summary>
        public override void Find()
        {
        // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");


            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string brandEntered = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate through loaded appliances
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (appliance.Brand == brandEntered)
                {
                    found.Add(appliance);
                }
            }


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        ///-------------------------------------------------------------------------- Displays Refridgerators--------------------------------------------------------------------------
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            // Write "Enter number of doors: "

            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");
            Console.WriteLine("Enter number of doors:");

            // Create variable to hold entered number of doors
            int doorNumberEntered;

            // Get user input as string and assign to variable
            string userDoorInput = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            if (!int.TryParse(userDoorInput, out doorNumberEntered))
            {
                Console.WriteLine("Invalid Input. Please enter a valid number.");
                return;
            }
            else { }

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
                // Test that current appliance is a refrigerator
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;
            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator refrigerator)
                {
                    if (doorNumberEntered == 0 || refrigerator.Doors == doorNumberEntered)
                    {
                        found.Add(refrigerator);
                    }
                }
            }

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// --------------------------------------------------------------------------Displays Vacuums--------------------------------------------------------------------------
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"

            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");
            Console.WriteLine("Enter grade:");

            // Get user input as string and assign to variable
            string inputGrade = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            // Return to calling (previous) method
            // return;
            switch (inputGrade)
            {
                case "0":
                    grade = "Any";
                    break;
                case "1":
                    grade = "Residential";
                    break;
                case "2":
                    grade = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
            Console.WriteLine("Enter voltage:");

            // Get user input as string
            string inputVoltage = Console.ReadLine();
            // Create variable to hold voltage
            int voltage = 0;

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            switch (inputVoltage)
            {
                case "0":
                    voltage = 0;
                    break;
                case "1":
                    voltage = 18;
                    break;
                case "2":
                    voltage = 24;
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            foreach (var appliance in Appliances)
            {
                if (appliance is Vacuum vacuum)

                // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                // Add current appliance in list to found list
                {
                    if ((grade == "Any" || vacuum.Grade == grade) &&
                        (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        found.Add(vacuum);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        
        }

        /// <summary>
        /// --------------------------------------------------------------------------Displays microwaves--------------------------------------------------------------------------
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"
            Console.WriteLine("Possible options:\n");
            Console.WriteLine("'A' - (0) Any");
            Console.WriteLine("'K' - (1) Kitchen");
            Console.WriteLine("'W' - (2) Work site");
            Console.WriteLine("Enter room type:");

            // Get user input as string and assign to variable
            string roomTypeInput = Console.ReadLine();

            // Create character variable that holds room type
            char roomType;

            // Test input is "0"
                // Assign 'A' to room type variable
            // Test input is "1"
                // Assign 'K' to room type variable
            // Test input is "2"
                // Assign 'W' to room type variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;
            switch (roomTypeInput)
            {
                case "A" or "a" or "0":
                    roomType = 'A';
                    break;
                case "K" or "k" or "1":
                    roomType = 'K';
                    break;
                case "W" or "w" or "2":
                    roomType = 'W';
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }
            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (appliance is Microwave microwave)
                {
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        found.Add(microwave);
                    }
                    
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// --------------------------------------------------------------------------Displays dishwashers--------------------------------------------------------------------------
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"
            Console.WriteLine("Possible options:");
            Console.WriteLine("'A' - (0) Any");
            Console.WriteLine("'Qt' - (1) Quietest");
            Console.WriteLine("'Qr' - (2) Quieter");
            Console.WriteLine("'Qu' - (3) Quiet");
            Console.WriteLine("'M' - (4) Moderate");
            Console.WriteLine("Enter sound rating:");

            // Get user input as string and assign to variable
            string soundInput = Console.ReadLine();

            // Create variable that holds sound rating
            string soundRating;

            // Test input is "0"
                // Assign "Any" to sound rating variable
            // Test input is "1"
                // Assign "Qt" to sound rating variable
            // Test input is "2"
                // Assign "Qr" to sound rating variable
            // Test input is "3"
                // Assign "Qu" to sound rating variable
            // Test input is "4"
                // Assign "M" to sound rating variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
            switch (soundInput)
            {
                case "0" or "A" or "a":
                    soundRating = "Any";
                    break;
                case "1"or "Qt" or "qt":
                    soundRating = "Qt";
                    break;
                case "2" or "Qr" or "qr":
                    soundRating = "Qr";
                    break;
                case "3" or "Qu" or "qu":
                    soundRating = "Qu";
                    break;
                case "4" or "M" or "m":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
                // Test if current appliance is dishwasher
                    // Down cast current Appliance to Dishwasher
            foreach (var appliance in Appliances)

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list
            {
                if (appliance is Dishwasher dishwasher &&
                    (soundRating == "Any" || dishwasher.SoundRating == soundRating))
                {
                    found.Add(dishwasher);
                }
            }

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// --------------------------------------------------------------------------Generates random list of appliances--------------------------------------------------------------------------
        /// </summary>
        public override void RandomList()
        {

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances:");
            // Get user input as string and assign to variable
            string userRandomInput = Console.ReadLine();
            // Convert user input from string to int
            int num = int.Parse(userRandomInput);

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through appliances
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                switch (userRandomInput)
                {
                    case "0":
                        found.Add(appliance);
                        break;
                    case "1":
                        if (appliance is Refrigerator) found.Add(appliance);
                        break;
                    case "2":
                        if (appliance is Vacuum) found.Add(appliance);
                        break;
                    case "3":
                        if (appliance is Microwave) found.Add(appliance);
                        break;
                    case "4":
                        if (appliance is Dishwasher) found.Add(appliance);
                        break;
                }
            }

            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, num);
        }
    }
}
