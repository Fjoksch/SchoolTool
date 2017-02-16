namespace SchoolTool {
    //All JSON Queries from the WebUntis API translated to C#
    public struct WebUnitsJsonSchemes {
        #region Special Classes
        //Base-Class for all Queries
        public class WebUntisQuery {
            public string id;
            public string method;
            public string jsonrpc = "2.0";

            public class @params { }
        }
        //Parameter Class for JSON Query Method Parameters
        public class @params {
            public string user = "ANDROID";
            public string password;
            public string client;
        }

        //Response or Result from a Query
        public class result {
            public string sessionId;
            public int personType;
            public int personId;
        }
        #endregion

        #region Individual Queries
        //Authenticate the given user and start a session
        public class Authentication : WebUntisQuery {
            public string id;
            public string method = "authenticate";
            public @params @params;
            public string password;
        }

        //End the session
        public class Logout : WebUntisQuery {
            public string id;
            public string method = "logout";
            public @params @params;
        }

        //Get list of teachers
        public class Teachers : WebUntisQuery {
            public string id;
            public @params @params = new @params();
            public readonly string method = "getTeachers";
        }

        //Get list of students
        public class Students : WebUntisQuery {
            public string id;
            public string method = "getStudents";
            public @params @params;
        }
        #endregion
    }
}