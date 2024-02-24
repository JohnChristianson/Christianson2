/********************************************************************
*** NAME : John A Christianson                                    ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #2                                    ***
*** DUE DATE : 02-26-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Create user-defined ADTs named Viking and       *** 
                  Global, accompanied by an interface IView. The  ***
                  Viking class contains five properties which     ***
                  are unique to each class instance.              ***
********************************************************************/

namespace VikingNS {

    public class Viking {
        public string Name { get; set; }
        public Status Status { get; set; }
        public short Health { get; set; }
        public Weapon Weapon { get; set; }
        public bool Shield { get; set; }

/********************************************************************
*** METHOD Viking                                                 ***
*********************************************************************
*** DESCRIPTION : Copy constructor creates a copy of a Viking     ***
                  instance by calling the default constructor     ***
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
                  the Viking class and populates its fields from  ***
                  input arguments                                 ***
*** INPUT ARGS : name, status, health, weapon, shield             ***
*** OUTPUT ARGS : none                                            ***
*** IN/OUT ARGS : none                                            ***
*** RETURN : none                                                 ***
********************************************************************/
        public Viking(string name = "Bjorn", Status status = Status.KARL, short health = 150, Weapon weapon = Weapon.AXE, bool shield = false) {
            Name = name;
            Shield = shield;
            Health = health;
            Status = status;
            Weapon = weapon;
        }

    }
}
