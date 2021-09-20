using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }


        public void Accelerate() 
        { 
                this.Speed = 10; 
           
            if (this.Make == "Ferrari") this.Speed += 10; }
        
        
        
        public void SetModel(string mod) { this.Model = mod; }

        public void SetMake(string mak)
        { this.Make = mak; }
       public int GetSpeed() { return this.Speed; }

        public bool IsSpeeding()
        {
            bool spd = false;
            if (this.Speed > 70) { spd = true; } else { spd = false; };
            return spd;
        }
        public void Brake()
        {
            if (this.Speed ==1) this.Speed = 0;
            if (this.Speed == 10) this.Speed = 3;

            if (this.AutoBrakeActive) this.Speed = this.Speed / 2;
        }
        //public void Brake(bool d) { if (AutoBrakeActive) this.Speed = this.Speed / 2; }


    }
}
