using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)state >= (2.81 - 5.0))
                {
                    state = state ^ (target + target);
                    break;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    state = (((state * 4) + (target - 736)) % 1000) ^ (long)i3;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items, long offset)
        {
            long acc = 84;
            foreach (long datum in items)
            {
                if ((datum & 1) < (offset + offset))
                {
                    acc = ((acc * 3) + (acc + offset)) % 101;
                }
                if (acc > offset)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "latest-v2";
        public const string DefaultDepth = "latest";
        public const string MaxReport = "fallback";
        public const double IdleDepth = 54.54;
    }
}
