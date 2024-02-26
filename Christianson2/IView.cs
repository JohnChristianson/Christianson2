/********************************************************************
*** NAME : John A Christianson                                    ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #2                                    ***
*** DUE DATE : 02-26-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Create user-defined ADTs named Viking and       *** 
                  Global, accompanied by an interface IView. The  ***
                  IView class contains two methods which display  ***
                  properties of a Viking instance.                ***
********************************************************************/



namespace VikingNS {

    public static class IView {

/********************************************************************
*** METHOD viewH                                                  ***
*********************************************************************
*** DESCRIPTION : Displays properties of a Viking instance        ***
                  in horizontal format                            ***
*** INPUT ARGS : viking                                           ***
*** OUTPUT ARGS : none                                            ***
*** IN/OUT ARGS : none                                            ***
*** RETURN : none                                                 ***
********************************************************************/
        public static void viewH (Viking viking) {
            string statusFormatted = "";
            string weaponFormatted = "";

            switch (viking.Status) {
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

            switch (viking.Weapon) {
                case Global.Weapon.AXE:
                    weaponFormatted = "Axe";
                    break;
                case Global.Weapon.SWORD:
                    weaponFormatted = "Sword";
                    break;
            }
            //avoid using '\t' to allow spacing between words to be underlined
            Console.WriteLine("\x1B[4mName    Status  Health  Weapon  Shield\n\x1B[0m" + viking.Name + "\t" + statusFormatted + "\t" + viking.Health + "\t" + weaponFormatted + "\t" + viking.Shield + "\n");
        }


/********************************************************************
*** METHOD viewV                                                  ***
*********************************************************************
*** DESCRIPTION : Displays properties of a Viking instance        ***
                  in vertical format                              ***
*** INPUT ARGS : viking                                           ***
*** OUTPUT ARGS : none                                            ***
*** IN/OUT ARGS : none                                            ***
*** RETURN : none                                                 ***
********************************************************************/
        public static void viewV (Viking viking) {
            string statusFormatted = "";
            string weaponFormatted = "";

            switch (viking.Status) {
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

            switch (viking.Weapon) {
                case Global.Weapon.AXE:
                    weaponFormatted = "Axe";
                    break;
                case Global.Weapon.SWORD:
                    weaponFormatted = "Sword";
                    break;
            }
            Console.WriteLine("Name:\t" + viking.Name + "\nRace:\t" + statusFormatted + "\nHealth:\t" + viking.Health + "\nWeapon:\t" + weaponFormatted + "\nShield:\t" + viking.Shield + "\n");
        }

    }
}
