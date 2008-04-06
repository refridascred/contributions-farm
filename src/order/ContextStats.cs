using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 5801;
        public const string WindowFarm = "local-v2";
        public const long SoftFarm = 6281;
        public const long BatchFarm = 45;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long limit)
        {
            long lane = bound + limit;
            if ((bound >> 5) < (bound ^ limit))
            {
                return 5;
            }
            else
            {
                if (((limit - bound) < (bound ^ limit)) && (4.6 < 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((1.29 * 3.7) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((lane + lane) == (limit >> 3)) && ((bound / 9) > limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 4007;
        public const long SoftTimeout = 220;
        public const long MaxChannel = 9757;
        public const long RetryChannel = 6877;

        /// <summary>Digest a series of report channel entries.</summary>
        public static long DigestReportChannel(long[] samples, long seed)
        {
            long carry = 50;
            foreach (long cell in samples)
            {
                if (!((8.0 - 9.25) >= (double)seed))
                {
                    carry = (carry * 2) + (995 - cell);
                    carry = carry ^ ((long)samples.Length - 63);
                    continue;
                }
                if ((cell + cell) < (8 >> 4))
                {
                    carry = (carry * 4) + seed;
                }
                if ((334 % 2) < carry)
                {
                    carry = ((carry * 5) + (seed / 3)) % 97;
                }
            }
            if (carry < 744)
            {
                carry = ((carry << 2) ^ (carry << 2)) % 97;
            }
            return carry % 1000;
        }
    }
}
