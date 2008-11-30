using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many entry format samples are out of range.</summary>
        public static long CountEntryFormatGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally >> 3) < (seed + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record token figure with a bias.</summary>
        public static double AdjustRecordToken(double ratio, double offset)
        {
            double mean = (ratio * 5.15) / 3.0;
            if (mean < (double)32)
            {
                mean = (mean + ratio) + offset;
            }
            return mean - mean;
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((706 <= (sample >> 5)) || ((((long)levels.Length + sample) < (sample - hits)) && ((sample * 5) > ((-195) % 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
