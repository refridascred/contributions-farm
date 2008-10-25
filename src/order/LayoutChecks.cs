using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            New,
            Idle,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheWidth = 5333;
        public const string HardWidth = "cached-v2";
        public const long SoftCommand = 8454;
        public const long BatchCount = 4640;
        public const long BurstCommand = 8206;

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long LookupContributiRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every support payload entry stays within the limit.</summary>
        public static bool CheckSupportPayloadRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 1.72;
            return (mean - (ratio - mean)) + floor;
        }
    }
}
