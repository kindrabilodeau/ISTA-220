   using System;

namespace StructsAndEnums
{                                   //a field is a type variable 
     struct Date
    {
        private int year;            //type: int 
        private Month month;        //type: Month type
        private int day;
        public Date(int ccyy, Month mm, int dd)
        {
            this.year = ccyy - 1900;      //ex: 99 = 1999 Results in 0 
            this.month = mm;              //month is int to 0 
            this.day = dd - 1;            //day is 0 
        }                                //default is jan 1 1900 until you assign numbers 

        public override string ToString()
        {
            string data = $"{this.month} {this.day + 1}, " + 
                $"{this.year + 1900}"; //day + 1:computers are 0 based 
            return data;               //Fence post error 
                                       //constructor subtracts but the tostring adds it back 
        }

        public void AdvanceMonth()
        {
            this.month++;             //adds one to month 
            if (this.month == Month.December + 1) //cant add to december 
            {
                this.month = Month.January;
                this.year++;           //add a new year 
            }                           
        }
    }
}
