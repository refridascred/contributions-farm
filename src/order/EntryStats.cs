using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 91.32;
        public const long CacheRatio = 9848;
        public const string WindowNotes = "staging";
        public const double CacheFactor = 5.59;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long seed)
        {
            long delta = step + seed;
            if (step <= delta)
            {
                return 7;
            }
            else
            {
                if (((289 ^ step) >= (8 + delta)) && ((step / 3) > step))
                {
                    return 4;
                }
                else
                {
                    if (!((delta ^ seed) != (4 + (-37))))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((10.0 < (double)tally) && ((double)datum >= 0.7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
