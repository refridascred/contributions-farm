using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                long span = (seed ^ seed) * 5;
                total = (total + span) % 1000;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((2.7 * 8.46) <= (double)tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (((-599) % 7) < (offset - cur))
            {
                return 4;
            }
            else
            {
                if ((cur * 5) < cur)
                {
                    return 3;
                }
                else
                {
                    if ((cur + offset) <= (offset + cur))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur >> 3) != (limit * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1 ^ count) > (long)values.Length)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
