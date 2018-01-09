using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Countdown
{
    public class Time
    {
        public int Days { get; protected set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Time()
        {
            Days = 0;
            Hour = 0;
            Minute = 0;
            Second = 0;
        }
        public Time(int _Hour, int _Minute, int _Second)
        {
            Days = 0;
            Hour = _Hour;
            Minute = _Minute;
            Second = _Second;
        }

        #region SubtractTime
        public void SubtractSeconds(int _Second)
        {
            Second -= _Second;

            while (Second < 0)
            {
                Second += 60;
                SubtractMinutes(1);
            }
        }
        public void SubtractMinutes(int _Minute)
        {
            Minute -= _Minute;

            while (Minute < 0)
            {
                Minute += 60;
                SubtractHours(1);
            }
        }
        public void SubtractHours(int _Hour)
        {
            Hour -= _Hour;

            while (Hour < 0)
            {
                Hour += 24;
                Days--;
            }
        }

        public bool SubtractTime(int _Hour, int _Minute, int _Second)
        {
            if (_Second >= 60 || _Minute >= 60 || _Hour >= 24)
            {
                return false;
            }

            SubtractSeconds(_Second);
            SubtractMinutes(_Minute);
            SubtractHours(_Hour);

            return true;
        }
        public void SubtractTime(DateTime _dateTime)
        {
            SubtractSeconds(_dateTime.Second);
            SubtractMinutes(_dateTime.Minute);
            SubtractHours(_dateTime.Hour);
        }
        public void SubtractTime(Time _Time)
        {
            SubtractSeconds(_Time.Second);
            SubtractMinutes(_Time.Minute);
            SubtractHours(_Time.Hour);
        }
        #endregion

        #region AddTime
        public void AddSeconds(int _Second)
        {
            Second += _Second;

            while (Second >= 60)
            {
                Second -= 60;
                AddMinutes(1);
            }
        }
        public void AddMinutes(int _Minute)
        {
            Minute += _Minute;

            while (Minute >= 60)
            {
                Minute -= 60;
                AddHours(1);
            }
        }
        public void AddHours(int _Hour)
        {
            Hour += _Hour;

            while (Hour >= 24)
            {
                Hour -= 24;
                Days++;
            }
        }

        public bool AddTime(int _Hour, int _Minute, int _Second)
        {
            if (_Hour >= 24 || _Minute >= 60 || _Second >= 60)
            {
                return false;
            }

            AddSeconds(_Second);
            AddMinutes(_Minute);
            AddHours(_Hour);

            return true;
        }
        public void AddTime(DateTime _dateTime)
        {
            AddSeconds(_dateTime.Second);
            AddMinutes(_dateTime.Minute);
            AddHours(_dateTime.Hour);
        }
        public void AddTime(Time _Time)
        {
            AddSeconds(_Time.Second);
            AddMinutes(_Time.Minute);
            AddHours(_Time.Hour);
        }
        #endregion

        #region TimeDifference
        public Time timeDifference(DateTime _start, Time _end)
        {
            Time tempTime = new Time(_end.Hour, _end.Minute, _end.Second);
            tempTime.SubtractTime(_start);

            return tempTime;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            string returnString = Hour.ToString("D2") + ":" + Minute.ToString("D2") + ":" + Second.ToString("D2");

            if (Days != 0)
            {
                returnString = Days + " Days and " + returnString;
            }

            return returnString;
        }

        public string ToString(bool ampm)
        {
            int tempHour = Hour;
            string ampmS = "";

            if (ampm)
            {
                ampmS = " AM";
                
                if (Hour == 0)
                {
                    tempHour = 12;
                }
                else if (Hour > 12)
                {
                    tempHour -= 12;
                    ampmS = " PM";
                }

                if (Hour == 12)
                {
                    ampmS = " PM";
                }
            }

            string returnString = tempHour.ToString("D2") + ":" + Minute.ToString("D2") + ":" + Second.ToString("D2") + ampmS;

            if (Days != 0)
            {
                returnString = Days + " Days and " + returnString;
            }

            return returnString;
        }

        public string ToString(string format)
        {
            string returnString = format.Replace("%H", Hour.ToString("D2")).Replace("%M", Minute.ToString("D2")).Replace("%S", Second.ToString("D2")).Replace("%h", Hour.ToString()).Replace("%m", Minute.ToString()).Replace("%s", Second.ToString());

            return returnString;
        }

        public string ToString(string format, bool ampm)
        {
            int tempHour = Hour;
            string ampmS = "";

            if (ampm && format.Contains("%a"))
            {
                ampmS = " AM";

                if (Hour == 0)
                {
                    tempHour = 12;
                }
                else if (Hour > 12)
                {
                    tempHour -= 12;
                    ampmS = " PM";
                }

                if (Hour == 12)
                {
                    ampmS = " PM";
                }
            }

            string returnString = format.Replace("%H", tempHour.ToString("D2")).Replace("%M", Minute.ToString("D2")).Replace("%S", Second.ToString("D2")).Replace("%h", tempHour.ToString()).Replace("%m", Minute.ToString()).Replace("%s", Second.ToString()).Replace("%a", ampmS);

            return returnString;
        }
        #endregion
    }
}
