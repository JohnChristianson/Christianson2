/********************************************************************
*** NAME : John A Christianson                                    ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #2                                    ***
*** DUE DATE : 02-26-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Create user-defined ADTs named Viking and       *** 
                  Global, accompanied by an interface IView. This ***
                  file is a driver class used to test the program ***
********************************************************************/

using VikingNS;

// instantiate a new Viking instance
Viking viking1 = new("John", Global.Status.JARL, 150, Global.Weapon.SWORD, false);
Viking viking2 = new Viking();

// display viking1 properties in vertical and horizontal format
viking1.ViewV();
viking2.ViewH();