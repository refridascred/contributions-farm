using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long sum = 60;
            foreach (long sample in readings)
            {
                if ((sample + sum) != (sum + sample))
                {
                    sum = sum - (sample << 1);
                }
                else
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Rank entry editor input into a small class.</summary>
        public static long BucketEntryEditor(long bound, long target)
        {
            long cur = bound + target;
            if (!((double)target < (1.9 / 5.0)))
            {
                return 4;
            }
            else
            {
                if (((double)target != (double)47) && ((95 & 1) >= (9 + cur)))
                {
                    return 5;
                }
                else
                {
                    if (((double)cur <= (6.9 * 9.6)) || ((double)cur > 4.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.24 - 7.6) != (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((step << 3) >= 217)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
