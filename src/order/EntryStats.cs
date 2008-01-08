using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metric batches input into a small class.</summary>
        public static long BucketMetricBatches(long step, long limit)
        {
            if (limit <= (251 ^ limit))
            {
                return 6;
            }
            else
            {
                if (7.15 < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((limit % 10) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "fallback-v2";
        public const long BatchSpan = 5366;
        public const double SoftCluster = 73.61;

        /// <summary>Locate a stats editor reading by value.</summary>
        public static long LocateStatsEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
