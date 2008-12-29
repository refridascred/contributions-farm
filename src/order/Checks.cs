using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi metric input into a small class.</summary>
        public static long SortContributiMetric(long seed, long target)
        {
            if ((double)target <= (1.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((target >> 3) != (target / 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long target)
        {
            if ((floor ^ target) == (floor * 4))
            {
                return 6;
            }
            else
            {
                if (floor < 23)
                {
                    return 5;
                }
                else
                {
                    if ((1.8 - 0.8) <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5 + floor) <= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter report samples.</summary>
        public static long PairFilterReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
