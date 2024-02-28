/********************************************************************
*** NAME : John A Christianson                                    ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #2                                    ***
*** DUE DATE : 02-26-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Create user-defined ADTs named Viking and       *** 
***               Global, accompanied by an interface IView. The  ***
***               Viking class contains five properties which     ***
***               are unique to each class instance.              ***
********************************************************************/
namespace VikingNS {

    public class Viking {
        public string Name { get; set; }
        public Global.Status Status { get; set; }
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }

/********************************************************************
*** METHOD Viking                                                 ***
*********************************************************************
*** DESCRIPTION : Copy constructor creates a copy of a Viking     ***
***               instance by calling the default constructor     ***
*** INPUT ARGS : viking                                           ***
*** OUTPUT ARGS : none                                            ***
*** IN/OUT ARGS : none                                            ***
*** RETURN : none                                                 ***
********************************************************************/
        public Viking(Viking viking) : this(viking.Name, viking.Status, viking.Health, viking.Weapon, viking.Shield) {}


/********************************************************************
*** METHOD Viking                                                 ***
*********************************************************************
*** DESCRIPTION : Default constructor creates a new instance of   ***
***               the Viking class and populates its fields from  ***
***               input arguments                                 ***
*** INPUT ARGS : name, status, health, weapon, shield             ***
*** OUTPUT ARGS : none                                            ***
*** IN/OUT ARGS : none                                            ***
*** RETURN : none                                                 ***
********************************************************************/
        public Viking(string name = "Bjorn", Global.Status status = Global.Status.KARL, short health = 150, Global.Weapon weapon = Global.Weapon.AXE, bool shield = false) {
            Name = name;
            Shield = shield;
            Health = health;
            Status = status;
            Weapon = weapon;
        }

        public void ViewH() {
            string statusFormatted = "";
            string weaponFormatted = "";

            switch (Status) {
                case Global.Status.JARL:
                    statusFormatted = "Jarl";
                    break;
                case Global.Status.KARL:
                    statusFormatted = "Karl";
                    break;
                case Global.Status.THRALL:
                    statusFormatted = "Thrall";
                    break;
                default:
                    statusFormatted = "ERR";
                    break;

            }

            switch (Weapon) {
                case Global.Weapon.AXE:
                    weaponFormatted = "Axe";
                    break;
                case Global.Weapon.SWORD:
                    weaponFormatted = "Sword";
                    break;
                default:
                    statusFormatted = "ERR";
                    break;
            }
            //avoid using '\t' to allow spacing between words to be underlined
            Console.WriteLine("\x1B[4mName    Status  Health  Weapon  Shield\n\x1B[0m" + Name + "\t" + statusFormatted + "\t" + Health + "\t" + weaponFormatted + "\t" + Shield + "\n");
        }

        public void ViewV() {
            string statusFormatted = "";
            string weaponFormatted = "";

            switch (Status) {
                case Global.Status.JARL:
                    statusFormatted = "Jarl";
                    break;
                case Global.Status.KARL:
                    statusFormatted = "Karl";
                    break;
                case Global.Status.THRALL:
                    statusFormatted = "Thrall";
                    break;
            }

            switch (Weapon) {
                case Global.Weapon.AXE:
                    weaponFormatted = "Axe";
                    break;
                case Global.Weapon.SWORD:
                    weaponFormatted = "Sword";
                    break;
            }
            Console.WriteLine("Name:\t" + Name + "\nRace:\t" + statusFormatted + "\nHealth:\t" + Health + "\nWeapon:\t" + weaponFormatted + "\nShield:\t" + Shield + "\n");
        }

    }
}
