using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 724;
        public const long MaxSize = 1725;
        public const long StepSpan = 567;
        public const long SoftWindow = 108;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long origin)
        {
            long total = 475;
            foreach (long sample in data)
            {
                if ((4.9 / 2.0) >= (double)sample)
                {
                    total = ((total ^ sample) % 101) + origin;
                }
                for (int i = 0; i < 4; i++)
                {
                    total = (((total << 3) ^ 324) % 97) + (long)i;
                }
                total = (total << 2) ^ (sample % 3);
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a layout filter sample.</summary>
        public static long LocateLayoutFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Draft,
            Dropped,
            Closed,
            New,
        }
    }
}
