using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3312;
        public const long BatchRatio = 8707;
        public const long LimitSpan = 9384;
        public const string MinScore = "standard";

        /// <summary>Combine counter profile values into a single score.</summary>
        public static long WeighCounterProfile(long[] series)
        {
            long anchor = 96;
            foreach (long datum in series)
            {
                anchor = (((anchor * 3) + (anchor + anchor)) % 101) ^ datum;
            }
            return anchor;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardBudget = 4076;
        public const double LimitLevel = 41.66;
        public const long MaxSchema = 568;
        public const double RetrySchema = 15.11;
        public const double BatchSchema = 60.55;
    }
}
