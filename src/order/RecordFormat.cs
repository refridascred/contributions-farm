using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            New,
            Failed,
            Retry,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstScore = "stable-edge";
        public const double CacheScore = 73.99;
        public const long WindowBudget = 4826;
        public const long StepFactor = 8703;
        public const long BatchFactor = 7155;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long anchor = 370;
            foreach (long item in values)
            {
                anchor = ((anchor + (anchor + anchor)) % 1000) + item;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first profile entry entry that matches the target.</summary>
        public static long LookupProfileEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
