﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Gx.Rs.Api.Util
{
    public interface DataSource
    {
        Stream InputStream { get; }

        Stream OutputStream { get; }

        String ContentType { get; }

        String Name { get; }
    }
}
