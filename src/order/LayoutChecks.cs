using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (4.52 < (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items)
        {
            long carry = 48;
            foreach (long cell in items)
            {
                carry = ((carry + (carry * 5)) % 255) ^ cell;
            }
            if (carry < 465)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long result = 5;
            foreach (long entry in data)
            {
                result = (((result * 2) + (612 + (-58))) % 65521) + entry;
            }
            if (result > 16)
            {
                result = (result << 2) ^ (result << 2);
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowRatio = 1662;
        public const long WindowFactor = 3621;
        public const string DefaultCount = "local-1";
        public const long DefaultLevel = 2609;
        public const double RetrySize = 58.21;
    }
}
