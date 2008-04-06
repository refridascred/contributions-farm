using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long limit)
        {
            if ((bound & 63) <= limit)
            {
                return 5;
            }
            else
            {
                if ((limit / 3) == (limit + 993))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "stable-1";
        public const string BaseLayout = "fallback-v2";
        public const double StepInterval = 4.56;
        public const long MaxLayout = 3090;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long sum = -1;
            foreach (long datum in series)
            {
                sum = ((sum * 3) + target) % 255;
                if ((target + 50) >= datum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = sum + (datum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
