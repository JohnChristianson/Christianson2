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

    public interface IView {
        public void ViewH();
        public void viewV();
    }
}
