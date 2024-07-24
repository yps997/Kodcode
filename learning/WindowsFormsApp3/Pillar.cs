using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Pillar { 
       public int Height {  get; set; }
        public int Width { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        
        public Pillar(int height, int width, string location)
        {
            height = Height;
            width = Width;
            location = Location;
            GetStatus(location);
        }
        public void GetStatus (string location)
        {
            if (location == "r")
            {
                if (Width >= 4)
                {
                    if (Height <= 3)
                    { Status = "רשות הרבים"; }
                    else if (Height > 3 && Height < 9)
                    { Status = "כרמלית"; }
                    else 
                    { Status = "רשות היחיד"; }
                }
                else
                { Status = "מקום פטור"; }
            }

            else if (location == "k")
            {
                if (Width >= 4)
                {
                    if (Height <= 10) {Status = "כרמלית"; }
                    else { Status = "רשות היחיד"; }
                }
                else {
                    if (Height > 10) { Status = "מחלוקת"; }
                    else { Status = "לא ידוע"; }
                }
            }
            else if (location == "y")
            {
                Status = "רשות היחיד";
            }
        }
      
        }
        }
    
