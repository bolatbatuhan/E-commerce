using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants;

public static class Messages
{
    public static string ProductAdded = "Urun eklendi";
    public static string ProductNameInvalid = "Urun ismi gecersiz";
    internal static List<Product> MaintenanceTime;
    internal static string ProductListed;
}
