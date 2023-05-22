// Yareni Perez
//IT112
//Notes:
namespace Perez_Robo_Dialer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone[] type = new Phone[10];

            type[0] = new HomePhone("CompuTest", "(303) 985-5060", "1");
            type[1] = new CellPhone("Curtis Manufacturing","(603) 532-4123", "2");
            type[2] = new HomePhone("Data Functions", "(800) 876-2524", "1");
            type[3] = new HomePhone("Donnay Repair","(708) 397-3330", "1");
            type[4] = new HomePhone("ErgoNomic Inc","(360) 434-3894", "1");
            type[5] = new HomePhone("ErgoSource","(800) 969-4374", "1");
            type[6] = new CellPhone("Fox Bay Industries","(800) 874-8527", "2");
            type[7] = new CellPhone("Glare-Guard","(800) 545-6254", "2");
            type[8] = new CellPhone("Hazard Comm Specialists","(407) 783-6641","2");
            type[9] = new CellPhone("Komfort Support","(714) 472-4409", "2");


            for (int i = 0; i < 10; i++)
            {
                type[i].dial();
                Console.WriteLine(type[i].dial());
              

            }
        }
    }
}