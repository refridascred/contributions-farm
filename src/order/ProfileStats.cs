using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double ratio = (3.3 * 5.38) * 1.0;
            return ((ratio + (double)2) + gain) + span;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Ready,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 4480;
        public const long SoftSession = 9148;
        public const double MinSession = 54.01;
    }
}
