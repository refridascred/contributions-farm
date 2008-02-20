using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (8.6 <= (double)seed)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long TallySupportCommandMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((9 + seen) < datum) || !((step % 97) > (step * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
