using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream_Countdown
{
    public class handleScript
    {
        private StreamReader reader;
        private string scriptLocation;
        private string endText = "";
        public List<string> lines { get; protected set; }
        public bool hasEnd { get; protected set; }
        
        public handleScript(string _location)
        {
            lines = new List<string>();
            hasEnd = false;

            scriptLocation = _location;

            loadScript();
        }

        /// <summary>
        /// Returns a string based on what the Script would return
        /// </summary>
        /// <param name="_currentTime">Current Time</param>
        /// <returns></returns>
        public string getResult(Time _currentTime)
        {
            string[] splittedLine;
            string otherwise = "%H:%M:%S";

            for (int i = 0; i < lines.Count; i++)
            {
                if (hasEnd) // End Text set?
                {
                    if (_currentTime.Hour == 0 && _currentTime.Minute == 0 && _currentTime.Second == 0) // Has the time come for the End text?
                    {
                        return endText;
                    }
                }
                if (lines[i].StartsWith("#IF-")) // Is this Line a IF-Condition?
                {
                    if (parseCondition(lines[i].Substring(4), _currentTime)) // Is the condition true?
                    {
                        return lines[i + 1].Trim('\'');
                    }
                    i++;
                }
                else if (lines[i].StartsWith("#MIF-")) // Is this Line a MultiIF-Condition?
                {
                    bool condition1 = false;
                    splittedLine = lines[i].Split(new char[] { '|', '&' }); // Seperate all of the Conditions

                    if (lines[i].Substring(splittedLine[0].Length, 1) == "|") // Is the first Condition tie an Or?
                    {
                        if (parseCondition(splittedLine[0].Substring(5), _currentTime) || parseCondition(splittedLine[1], _currentTime))
                        {
                            condition1 = true;
                        }
                    }
                    else if (lines[i].Substring(splittedLine[0].Length, 1) == "&") // Is the first Condition tie an And?
                    {
                        if (parseCondition(splittedLine[0].Substring(5), _currentTime) && parseCondition(splittedLine[1], _currentTime))
                        {
                            condition1 = true;
                        }
                    }

                    if (splittedLine.Length == 2) // If there is just one tie, check if it was true and return.
                    {
                        if (condition1)
                        {
                            return lines[i + 1].Trim('\'');
                        }
                    }
                    else if (splittedLine.Length == 3) // If there are 2 ties, check if the second tie is true - so does the first?
                    {
                        if (lines[i].Substring(splittedLine[0].Length + splittedLine[1].Length,1) == "|")
                        {
                            if (condition1 || parseCondition(splittedLine[2], _currentTime))
                            {
                                return lines[i + 1].Trim('\'');
                            }
                        }
                        else if (lines[i].Substring(splittedLine[0].Length + splittedLine[1].Length, 1) == "&")
                        {
                            if (condition1 && parseCondition(splittedLine[2], _currentTime))
                            {
                                return lines[i + 1].Trim('\'');
                            }
                        }
                    }
                }
                else if (lines[i].StartsWith("#Otherwise")) // If the Otherwise Text is found, save it for later
                {
                    otherwise = lines[i + 1].Trim('\'');
                    i++;
                }
            }

            return otherwise;
        }

        /// <summary>
        /// Loads a script into the script handeler
        /// </summary>
        public void loadScript()
        {
            hasEnd = false;
            reader = new StreamReader(scriptLocation);

            while (!reader.EndOfStream)
            {
                lines.Add(reader.ReadLine());
                if (lines.Count > 1)
                {
                    if (lines[lines.Count - 2].StartsWith("#End"))
                    {
                        hasEnd = true;
                        endText = lines[lines.Count - 1].Trim('\'');
                    }
                }
            }
            reader.Close();
        }

        /// <summary>
        /// Parses the given Condition from a string and returns what it would give in and if
        /// </summary>
        /// <param name="Condition">The Condition</param>
        /// <param name="_currentTime">Current Time</param>
        /// <returns></returns>
        private bool parseCondition(string Condition, Time _currentTime)
        {
            string[] splittedLine = Condition.Split(new char[] { '=', '<', '>' });
            int timevalue;
            bool wasOK;
            bool returnValue = false;

            wasOK = Int32.TryParse(splittedLine[1], out timevalue);
            if (wasOK)
            {
                switch (splittedLine[0])
                {
                    case "seconds":     // When Seconds are Conditioned
                        switch (Condition.Substring(7, 1))
                        {
                            case "=":
                                if (_currentTime.Second == timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                            case "<":
                                if (_currentTime.Second < timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                            case ">":
                                if (_currentTime.Second > timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                        }
                        break;
                    case "minutes":     // When Minutes are Conditioned
                        switch (Condition.Substring(7, 1))
                        {
                            case "=":
                                if (_currentTime.Minute == timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                            case "<":
                                if (_currentTime.Minute < timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                            case ">":
                                if (_currentTime.Minute > timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                        }
                        break;
                    case "hours":       // When Hours are Conditioned
                        switch (Condition.Substring(5, 1))
                        {
                            case "=":
                                if (_currentTime.Hour == timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                            case "<":
                                if (_currentTime.Hour < timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                            case ">":
                                if (_currentTime.Hour > timevalue)
                                {
                                    returnValue = true;
                                }
                                break;
                        }
                        break;
                }
            }

            return returnValue;
        }
    }
}
