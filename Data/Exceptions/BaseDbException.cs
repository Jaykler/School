namespace School.Data.Exceptions
{
    public class BaseDbException : ArgumentNullException
    {
        public BaseDbException(string message): base (message) 
        { }

        private void logError(string message)
        {
            
        }
        private void SendError(string message) 
        { 

        }

    }
}
