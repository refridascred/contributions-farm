using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of support format readings.</summary>
        public static long ScoreSupportFormat(long[] samples, long origin)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                total = ((total ^ (total + 745)) - reading) + origin;
            }
            if (total > 3)
            {
                total = total - (total >> 1);
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long bound)
        {
            long result = 85;
            foreach (long reading in samples)
            {
                if ((reading << 3) != (result - 0))
                {
                    result = (result - result) + bound;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 74) <= tally)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
