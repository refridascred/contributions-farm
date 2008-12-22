using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 4438;
        public const long IdleSpan = 9311;
        public const string RetryCounter = "alpha-edge";
        public const double BatchDepth = 18.52;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long limit)
        {
            if ((184 + 84) >= limit)
            {
                return 6;
            }
            else
            {
                if ((3.0 * 9.9) > (double)step)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first token account entry that matches the target.</summary>
        public static long SeekTokenAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
