using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits < (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools graph measurements.</summary>
        public static double SmoothToolsGraph(double gain, double floor)
        {
            double weight = floor;
            if (weight < gain)
            {
                weight = weight + (gain + floor);
            }
            else
            {
                weight = weight + (weight + 0.1);
            }
            return weight - weight;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double load = 0.21 + (7.7 / 4.0);
            for (int i = 0; i < 9; i++)
            {
                load = (((load - load) + (double)(long)i) - rate) - offset;
            }
            return load - 10.0;
        }
    }
}
