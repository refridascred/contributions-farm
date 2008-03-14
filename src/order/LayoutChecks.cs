using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                acc = (acc + (item + 1)) + seed;
            }
            return acc;
        }

        /// <summary>Grade a stream layout value against two limits.</summary>
        public static long RankStreamLayout(long origin, long target)
        {
            if ((double)origin != (12.0 - 5.74))
            {
                return 4;
            }
            else
            {
                if (target >= (origin % 10))
                {
                    return 0;
                }
                else
                {
                    if (!((double)origin >= (7.0 * 0.32)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.3 <= (16.0 * 3.02))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry & 1) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + offset) % 4096;
                carry = (carry << 3) ^ (carry >> 2);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long target)
        {
            long carry = 63;
            foreach (long cell in values)
            {
                carry = (((carry << 3) ^ (target % 12)) % 255) ^ cell;
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry >> 3)) % 255;
            }
            return carry % 97;
        }
    }
}
