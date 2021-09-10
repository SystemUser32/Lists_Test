using System;
using System.Collections.Generic;

namespace CsharpGenerics_List
{
    public class ListContainer
    {

        List<string> li = new List<string>();

        public void _Add_(string x)
        {
            li.Add(x);
        }

        public string Value(int x)
        {
            return li[x];
        }
    }
}
