using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            if ((2.8 * 7.18) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)offset > (3.7 + 8.4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double span)
        {
            double scale = 9.62;
            return ((scale + 8.75) + ratio) + span;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "standard-v2";
        public const long LimitSpan = 3465;
        public const long WindowTimeout = 4815;
        public const string MinInterval = "strict-1";
        public const long CacheLevel = 5988;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Queued,
            Closed,
        }
    }
}
