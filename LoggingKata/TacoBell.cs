﻿namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public TacoBell(double lon, double lat, string name)
        {
            Name = name;
            Location = new Point(lon, lat);
        }
        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
