using System;
using System.IO;

namespace MegaEscritorioForm
{
    class Order
    {
        // Class Variables
        private Desk desk;
        private bool rushOrder;
        public string outputFileName = "";
        private int rushDays;
        private double[,] priceRushOrderTable = new double[3, 3];

        public Order(Desk desk, int rushDays)
        {
            this.desk = desk;
            setRushDays(rushDays);
            rushOrder = rushDays != 0;

            ReadFile();
        }
        // Getters
        public int getRushDays()
        {
            return rushDays;
        }

        public bool isRushOrder()
        {
            return rushOrder;
        }

        public double getTotalPrice()
        {
            double totalPrice = CalculateTotal();
            return totalPrice;
        }

        public void setRushDays(int days)
        {
            rushDays = days;
        }

        // This function reads the price table for delivery options from a file
        private void ReadFile()
        {
            int x = 0;
            int y = 0;

            StreamReader reader = new StreamReader("deliveryPrices.txt");

            // Store the information in the text file into a two dimensional array
            while (reader.EndOfStream == false)
            {
                string value = reader.ReadLine();
                priceRushOrderTable[x, y] = Convert.ToDouble(value);

                x++;
                if (x % 3 != 0) continue;
                x = 0;
                y++;
            }
            reader.Close();
        }

        // This method will write the order information to JSON file
        public void WriteFile()
        {
            try
            {
                Console.Write("\nEnter filename to save price information (include new path if desired):  \n");
                outputFileName = Console.ReadLine();
                string[] lines = {
                    "{",
                    string.Format("\"Desk Width\":{0},",Convert.ToString(desk.getWidth())),
                    string.Format("\"Desk Length\":{0},",Convert.ToString(desk.getLength())),
                    string.Format("\"Materials\":{0},",desk.getMaterial()),
                    string.Format("\"# of Drawers\":\"{0}\",",Convert.ToString(desk.getNumDrawers())),
                    string.Format("\"Rush Days\":\"{0}\",",Convert.ToString(getRushDays())),
                    string.Format("\"Total Price\":{0},",Convert.ToString(getTotalPrice())),"}"
                };
                File.WriteAllLines(@outputFileName, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // This method will display the delivery price table to the Console
        public void DisplayDeliveryPriceTable()
        {
            for (int i = 0; i < 3; i++)
            {
                int j;
                for (j = 0; j < 3; j++)
                {
                    Console.Out.Write(priceRushOrderTable[j, i] + " ");
                }

                if (j % 3 == 0)
                {
                    Console.Out.WriteLine();
                }
            }
        }

        // This method calculates the total price of the order
        public double CalculateTotal()
        {
            double orderTotal = 200.00;  // Add desks have a base price of 200
            double area = desk.getSurfaceArea();

            // If surface area is greater than 1000 square inches charge 5 dollars per extra square inch
            if (area > 1000.00)
            {
                orderTotal += (area - 1000) * 5;
            }

            // Calculate cost per number of drawers.
            // Drawers are 50 dollars each
            if (desk.getNumDrawers() >= 1)
            {
                orderTotal += desk.getNumDrawers() * 50.00;
            }

            // Calculate desk material cost
            switch (desk.getMaterial())
            {
                case "oak":
                    orderTotal += 200.00;
                    break;
                case "laminate":
                    orderTotal += 100.00;
                    break;
                case "pine":
                    orderTotal += 50.00;
                    break;
                default:
                    Console.Out.WriteLine("\nThis should never happen\n");
                    break;
            }

            // Calculate the order charge using the price rush order table 
            double orderCharge = 0;

            if (isRushOrder())
            {
                if (area < 1000.00)
                {
                    switch (getRushDays())
                    {
                        case 3:
                            orderCharge = priceRushOrderTable[0, 0];
                            break;
                        case 5:
                            orderCharge = priceRushOrderTable[0, 1];
                            break;
                        case 7:
                            orderCharge = priceRushOrderTable[0, 2];
                            break;
                    }
                }
                else if (area >= 1000.00 && area <= 1999.00)
                {
                    switch (getRushDays())
                    {
                        case 3:
                            orderCharge = priceRushOrderTable[1, 0];
                            break;
                        case 5:
                            orderCharge = priceRushOrderTable[1, 1];
                            break;
                        case 7:
                            orderCharge = priceRushOrderTable[1, 2];
                            break;
                    }
                }
                else if (area >= 2000.00)
                {
                    switch (getRushDays())
                    {
                        case 3:
                            orderCharge = priceRushOrderTable[2, 0];
                            break;
                        case 5:
                            orderCharge = priceRushOrderTable[2, 1];
                            break;
                        case 7:
                            orderCharge = priceRushOrderTable[2, 2];
                            break;
                    }
                }

            }
            orderTotal += orderCharge;

            return orderTotal;
        }
    }
}
