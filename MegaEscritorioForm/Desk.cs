using System;

namespace MegaEscritorioForm
{
    class Desk
    {
        private double width;
        private double length;
        private int numDrawers;

        enum MaterialType { laminate, oak, pine };
        private MaterialType material;


        //Default Constructor
        public Desk()
        {
            setWidth(0);
            setLength(0);
            setNumDrawers(0);
            setMaterial(null);
        }

        //Constructor that takes 4 arguments
        public Desk(double width, double length, int numDrawers, string material)
        {
            setWidth(width);
            setLength(length);
            setMaterial(material);
            setNumDrawers(numDrawers);
        }

        // Getters
        public double getWidth()
        {
            return width;
        }

        public double getLength()
        {
            return length;
        }

        public double getSurfaceArea()
        {
            return getLength() * getWidth();
        }

        public int getNumDrawers()
        {
            return numDrawers;
        }

        public string getMaterial()
        {
            return Convert.ToString(material);
        }

        // Setters
        public void setWidth(double width)
        {
            this.width = width;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setNumDrawers(int numDrawers)
        {
            this.numDrawers = numDrawers;
        }

        public void setMaterial(string material)
        {
            switch (material)
            {
                case "oak":
                    this.material = MaterialType.oak;
                    break;
                case "laminate":
                    this.material = MaterialType.laminate;
                    break;
                case "pine":
                    this.material = MaterialType.pine;
                    break;
                default:
                    Console.Out.WriteLine("\nThis should never happen\n");
                    break;
            }
        }
    }
}
