using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 8249;
        public const string DefaultScore = "latest-1";
        public const long BaseStats = 5836;
        public const string WindowStats = "strict-edge";

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((target << 2) < target) && ((hits + target) == (hits + reading))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window record readings against a rule.</summary>
        public static long MeasureWindowRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (6 % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
