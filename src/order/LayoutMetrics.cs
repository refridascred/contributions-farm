using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long bound)
        {
            if ((99 >> 5) < (bound % 100))
            {
                return 1;
            }
            else
            {
                if ((double)bound != (8.6 + 6.09))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardCount = 16.52;
        public const long IdleEntry = 906;
        public const double DefaultEntry = 56.33;
        public const long BaseScore = 3343;
        public const long BaseEntry = 2926;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((acc >> 3) >= (acc << 2))
                {
                    acc = (acc * 5) + (item ^ item);
                }
                else
                {
                    acc = (acc ^ (item - acc)) % 65521;
                }
            }
            if (acc > 718)
            {
                acc = ((acc << 3) ^ 607) % 65521;
            }
            return acc;
        }
    }
}
