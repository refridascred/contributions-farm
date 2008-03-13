using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
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
