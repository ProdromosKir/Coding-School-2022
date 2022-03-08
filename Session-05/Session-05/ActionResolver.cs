using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {

        
        public MessageLogger Logger { get; set; }
        public ActionEnum Action { get; set; }

        public ActionResolver()
        {
                
        }






        public ActionResponse Execute(ActionRequest request)
        {

            var response = new ActionResponse();
            string output = string.Empty;

            switch (request.Action)
            {
                case ActionEnumType.Convert:
                    output =  Action.Convert(request.Input);
                  
                    break;

                case ActionEnumType.Uppercase:
                    output = Action.Uppercase(request.Input);
                   
                    break;

                case ActionEnumType.Reverse:
                     output = Action.ReverseString(request.Input);
                     
                    break;
                    
            }
            response = new ActionResponse(request.RequestID, output);
            return response;

          



            
        }





        //public ActionResponse Execute(ActionRequest actionRequest)
        //{
        //    string response = string.Empty;
        //    ActionResponse actionResponse = null;


        //    if (actionRequest.Action == ActionEnumType.Convert)
        //    {
        //        response =  Action.Convert(actionRequest.Input);


        //    }
        //    else if (actionRequest.Action == ActionEnumType.Uppercase)
        //    {
        //        response =  Action.Uppercase(actionRequest.Input);

        //    }
        //    else if (actionRequest.Action == ActionEnumType.Reverse)


        //    {
        //        response = Action.ReverseString(actionRequest.Input);

        //    }
        //    else
        //        return null;









        //public ActionResponse Execute(ActionRequest request)
        //{

        //    var response = new ActionResponse();

        //    // DO ALL THE THINGS!



        //    return response;
        //}
    }
}

