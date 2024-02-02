using System;
using System.Collections.Generic;

public class SalesPersonData {
    public int ID { get; set; }
    public string Department { get; set; }
    public string SalesPerson { get; set; }
    public int Quantity { get; set; }

    public static List<SalesPersonData> GetSalesData() {
        List<SalesPersonData> data = new List<SalesPersonData>();
        string[] salesPersons = { "Andrew Fuller", "Michael Suyama",
                                "Robert King", "Nancy Davolio",
                                "Margaret Peacock", "Laura Callahan",
                                "Steven Buchanan", "Janet Leverling" };
        var rnd = new Random();
        for (int i = 0; i < 10; i++) {
            SalesPersonData record = new SalesPersonData();
            record.ID = i;
            record.SalesPerson = salesPersons[rnd.Next(0, salesPersons.Length)];
            record.Quantity = rnd.Next(0, 100);
            record.Department = "Dept. #" + (i % 3 + 1);
            data.Add(record);
        }
        return data;
    }
}
