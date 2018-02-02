﻿using System.Collections;
using System.Collections.Generic;
using log4net;
using log4net.Util;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the TacoBells
    /// </summary>
    public class TacoParser
    {

        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ITrackable Parse(string line)
        {
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                Logger.Error("Line found without 3 cells.");
                return null; // Log that and return null
            }

            double.TryParse(cells[0], out var lon);
            double.TryParse(cells[1], out var lat);
            var name = cells[2];

            var tBell = new TacoBell(lon, lat, name);

            return tBell;

            // grab the long from your array at index 0
            // grab the lat from your array at index 1
            // grab the name from your array at index 2

            // Your going to need to parse your string as a `double`
            // which is similar to parse a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            //DO not fail if one record parsing fails, return null
            return null; //TODO Implement
        }
}
}