namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }






    }

    public class InventoryItems
    {
        public float Weight { get; set; }
        public float Volume { get; set; }

        public InventoryItems(float weight, float volume)
        {


            this.Weight = weight;
            this.Volume = volume;

        }




    }


    public class Pack
    {
        public float TotalWeight { get; set; }
        public float TotalVolume { get; set; }
        public int TotalItems { get; set; }
        private int ItemCount { get; set; }

        public InventoryItems[] Inventory { get; set; }
        public Pack(float TotalWeight, float TotalVolume, int Totalitems)
        {
            this.TotalWeight = TotalWeight;
            this.TotalVolume = TotalVolume;
            this.TotalItems = Totalitems;
            ItemCount = 0;
            Inventory = new InventoryItems[this.TotalItems];

        }
        public bool add(InventoryItems item)
        {

            if (item.Weight<TotalWeight && item.Volume<TotalVolume && ItemCount<TotalItems ) {

                Inventory[ItemCount]=item;
                ItemCount++;
                return true;
            
            }
            else { Console.WriteLine("se lleno la mochila pipipipipip"); 
            
            return false;
            }


        }
        public bool add(InventoryItems[] item)
        {

            if (item.Length+Inventory.Length<TotalItems) { 
            
            
            for(int i=ItemCount, e =item.Length;e<item.Length;e++,i++) {

                    if (i >= TotalItems) { return false ; } 

                    Inventory[i] = item[e];
                
                
                }
           return true;
            
            }
            else return false;


        }








    }




    public class Arrow : InventoryItems
    {


        public Arrow(float Weight = 0.1f, float Volume = 0.05f) : base(Weight, Volume)
        {




        }




    }


    public class Bow : InventoryItems
    {


        public Bow(float Weight = 1, float Volume = 4) : base(Weight, Volume)
        {




        }




    }

    public class Rope : InventoryItems
    {


        public Rope(float Weight = 1, float Volume = 1.5f) : base(Weight, Volume)
        {




        }




    }
    public class Water : InventoryItems
    {


        public Water(float Weight = 2, float Volume = 3) : base(Weight, Volume)
        {




        }




    }

    public class Food : InventoryItems
    {


        public Food(float Weight = 1, float Volume = 0.05f) : base(Weight, Volume)
        {




        }




    }

    public class Sword : InventoryItems
    {


        public Sword(float Weight = 5, float Volume = 3) : base(Weight, Volume)
        {




        }




    }

}
