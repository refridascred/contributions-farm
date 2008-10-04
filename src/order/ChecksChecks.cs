using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value - value) > (value % 12)) || ((count - value) != (count * 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank schema checks input into a small class.</summary>
        public static long SortSchemaChecks(long target, long bound)
        {
            if (2 < (target + target))
            {
                return 1;
            }
            else
            {
                if (0.6 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if (3.9 <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.56 * 3.6) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
