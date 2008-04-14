using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item ^ hits) < (offset - 56))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = 187;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 97;
                if (acc <= (acc ^ entry))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
                else
                {
                    acc = (acc ^ ((long)readings.Length - entry)) % 255;
                }
            }
            if (acc > (-9))
            {
                acc = ((acc * 2) + (acc + acc)) % 4096;
            }
            return acc % 65521;
        }
    }
}
