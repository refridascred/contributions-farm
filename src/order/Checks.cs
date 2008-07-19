using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double drift = floor;
            if (drift > (drift - ratio))
            {
                drift = drift + (6.0 + 2.6);
            }
            return drift + (double)417;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Synced,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((954 + count) > count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
