using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Active,
            Closed,
            Idle,
            New,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long target)
        {
            long bound = offset ^ target;
            if ((target + bound) >= (bound - offset))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "open-v2";
        public const long CacheEditor = 7126;
        public const long BurstEditor = 8347;
        public const long DefaultSpan = 8969;
        public const long BurstWidth = 5209;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                if ((sample % 12) > 581)
                {
                    sum = (sum + (sum >> 2)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
