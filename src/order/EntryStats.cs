using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long origin)
        {
            if ((double)920 < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin + bound) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((origin % 12) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples)
        {
            long result = 84;
            foreach (long entry in samples)
            {
                if (543 <= (result - entry))
                {
                    result = (result * 4) + (entry / 5);
                }
                if ((entry ^ entry) == (entry << 2))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 9320;
        public const string SoftDepth = "alpha";
        public const long DefaultTools = 7147;

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long score = 831;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = score - ((long)i * 3);
                }
                score = ((score << 3) ^ (offset + reading)) % 97;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
