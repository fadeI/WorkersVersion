using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkersVersion
{
    interface  ILogic
    {
       void updateDatabasedata();
       void deleteFromDatabase();
        bool valdateText( TextBox item);

        bool validateNumric(TextBox item);
    }
}
