using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long floor)
        {
            long carry = 365;
            foreach (long datum in levels)
            {
                if (((floor + datum) != (datum & 3)) && (carry <= (datum << 3)))
                {
                    carry = (carry << 3) ^ (datum + floor);
                }
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 5410;
        public const string SoftFilter = "standard-v2";
        public const long CacheFilter = 8176;

        /// <summary>Classify a githubfarm counter pair into a bucket.</summary>
        public static long ClassifyGithubfarmCounter(long target, long offset)
        {
            long slot = target + offset;
            if (((0 / 4) == (target % 10)) && ((6.86 - 14.0) >= (double)slot))
            {
                return 6;
            }
            else
            {
                if ((offset >= (target - offset)) || ((80 ^ offset) >= (target + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((target << 1) > slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
