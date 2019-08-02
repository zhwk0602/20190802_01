using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace _20190802_01
{
    [DefaultValue(Poweroff)]

    public enum  MachineState
    {
       Poweroff=1,
       Running=2,
       Sleeping=3
    }
}
