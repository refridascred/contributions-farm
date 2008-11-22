using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already route reading.</summary>
        public static double ProjectAlreadyRoute(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 <= (double)88)
            {
                ratio2 = (ratio2 + span) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - 9.59) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Draft,
            New,
            Queued,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (seed <= (seed >> 2))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
