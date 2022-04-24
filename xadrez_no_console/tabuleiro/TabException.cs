using System;

namespace tabuleiro
{
    internal class TabException : Exception
    {
        public TabException(string mess0) : base(mess0)
        {
        }
    }
}
