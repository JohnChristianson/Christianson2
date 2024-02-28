/********************************************************************
*** NAME : John A Christianson                                    ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #2                                    ***
*** DUE DATE : 02-26-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Create user-defined ADTs named Viking and       *** 
***               Global, accompanied by an interface IView. The  ***
***               Global class contains two public enumerated     ***
***               types, Status and Weapon, which are used in     ***
***               each Viking class instance                      ***
********************************************************************/
namespace VikingNS {
    
    public static class Global {
        public enum Status {
            JARL, KARL, THRALL
        }

        public enum Weapon {
            AXE, SWORD
        }
    }
    
}
