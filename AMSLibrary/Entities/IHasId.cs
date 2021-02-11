using System;
using System.Collections.Generic;
using System.Text;

namespace AMSLibrary.Entities
{
    interface IHasId
    {
        string GetId();
        string GetPrefix();
        void SetId(string id);
    }
}
