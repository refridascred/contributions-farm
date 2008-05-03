using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank contributi metric input into a small class.</summary>
        public static long RankContributiMetric(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (((seed + bound) > (bound % 97)) || ((double)cur >= (5.0 / 3.0)))
            {
                return 7;
            }
            else
            {
                if ((cur < seed) || (seed >= (-2)))
                {
                    return 8;
                }
                else
                {
                    if ((669 + bound) >= (11 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the report record series from a seed.</summary>
        public static long IterateReportRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 7342;
        public const double BurstSchema = 29.19;
        public const long HardSchema = 5816;
    }
}
