using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxLevel = 13.99;
        public const long LimitLevel = 937;
        public const double StepRatio = 91.49;
        public const long LimitRatio = 148;

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long TallyFilterReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell != (double)19))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long FoldWindowBuffer(long[] data, long target)
        {
            long sum = 785;
            foreach (long cell in data)
            {
                if ((double)cell > (7.0 * 3.0))
                {
                    sum = (sum << 2) ^ (1 - 35);
                }
            }
            if (sum > (-7))
            {
                sum = (sum << 3) ^ target;
            }
            return sum;
        }

        /// <summary>Classify a farm route pair into a bucket.</summary>
        public static long BucketFarmRoute(long seed, long seed2)
        {
            long prev = seed + seed2;
            if (seed < (seed - prev))
            {
                return 1;
            }
            else
            {
                if ((prev & 7) >= (11 ^ seed2))
                {
                    return 7;
                }
                else
                {
                    if ((9.23 / 9.0) != (double)seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
