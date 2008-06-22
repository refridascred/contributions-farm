using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a channel payload counter forward.</summary>
        public static long IterateChannelPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((sum + (long)i) == (95 - bound))
                {
                    sum = (sum - (sum + sum)) % 101;
                    continue;
                }
                sum = (sum << 3) ^ sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels)
        {
            long total = 35;
            foreach (long entry in levels)
            {
                total = (total ^ (total - total)) + entry;
            }
            if (total > 77)
            {
                total = ((total * 4) + (total - total)) % 4096;
            }
            return total % 97;
        }
    }
}
