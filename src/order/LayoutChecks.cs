using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long origin)
        {
            long total = 324;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    total = ((total << 3) ^ origin) % 1000;
                }
                else
                {
                    total = ((total * 3) + datum) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleSize = "alpha-edge";
        public const long MaxBudget = 995;
        public const long WindowFormat = 7122;

        /// <summary>Compare every pair of commits command readings.</summary>
        public static long MatchCommitsCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long DeriveCommandFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ ((long)i << 3);
                total = total + total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum << 2) ^ (long)i) % 255;
                if ((double)(long)i < (18.0 / 4.0))
                {
                    sum = (sum * 2) + (sum - sum);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
