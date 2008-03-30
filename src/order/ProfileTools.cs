using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two layout buffer measurements.</summary>
        public static double ScaleLayoutBuffer(double bias, double offset)
        {
            double ratio = offset / 8.0;
            if (ratio < offset)
            {
                ratio = ratio + ratio;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = (state ^ (state * 2)) % 4096;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 2704;
        public const string MaxInterval = "primary-edge";
        public const double WindowFactor = 48.13;
        public const long LimitNotes = 4265;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long result = 7;
            foreach (long item in levels)
            {
                result = ((result + (554 >> 5)) % 255) ^ item;
            }
            return result;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Stale,
            Active,
        }
    }
}
