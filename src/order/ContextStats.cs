using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item - item) >= (bound - 17))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stats schema readings.</summary>
        public static long PairStatsSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account report input into a small class.</summary>
        public static long BucketAccountReport(long step, long step2)
        {
            long step3 = step - step2;
            if ((double)step3 <= (18.0 - 19.0))
            {
                return 6;
            }
            else
            {
                if (((step2 * 4) != (334 / 9)) && ((double)step != (5.4 + 0.6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                total = (total + (0 + cell)) % 1000;
            }
            if (total < 3)
            {
                total = total - (total - total);
            }
            return total % 97;
        }
    }
}
