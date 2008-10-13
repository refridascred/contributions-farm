using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank entry counter input into a small class.</summary>
        public static long ClassifyEntryCounter(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((6.14 * 7.1) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((offset ^ bound) != (89 - offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 1) < bound2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double span)
        {
            double drift = (double)88 / 3.0;
            if (drift >= (span * 15.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 756;
        public const long CacheFormat = 8642;
        public const long LimitFormat = 7766;
        public const string BurstLevel = "fallback-1";

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the contributi queue entries that pass the check.</summary>
        public static long AuditContributiQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (5.13 - 3.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
