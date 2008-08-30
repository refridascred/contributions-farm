using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits <= (2 - hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain - (floor + gain);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
