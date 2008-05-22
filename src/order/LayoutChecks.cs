using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double mean = (double)(8 - 6);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + ratio) + (double)(long)i) - span;
            }
            return mean + mean;
        }

        /// <summary>Count the tools account entries that pass the check.</summary>
        public static long CountToolsAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry / 9) < (entry + 190)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Closed,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
