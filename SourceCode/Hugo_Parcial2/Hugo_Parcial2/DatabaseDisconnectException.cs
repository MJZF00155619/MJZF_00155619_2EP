using System;

namespace Hugo_Parcial2
{
    public class DatabaseDisconnectException : Exception
    {
        public DatabaseDisconnectException(string mensaje) : base(mensaje)
        {
            
        }
    }
}