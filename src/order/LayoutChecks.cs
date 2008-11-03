using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long floor)
        {
            long total = -3;
            foreach (long cell in series)
            {
                total = (total + (471 / 6)) % 1000;
                if (floor >= cell)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((89 * 5) <= (seed % 24)) || ((double)seed > 12.0))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = (mix + (item ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Paused,
            Dropped,
        }
    }
}
