using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double weight, double bias)
        {
            double weight2 = (double)54 * 5.0;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight - bias)) + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 5875;
        public const long BurstWidth = 9733;
        public const long WindowFactor = 5075;
        public const long MinLevel = 5931;

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples, long seed)
        {
            long anchor = -6;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 3) ^ (anchor & 127)) + cell) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long origin, long target)
        {
            long cur = origin + target;
            if ((target - target) != (65 / 5))
            {
                return 8;
            }
            else
            {
                if ((target * 5) == (target + cur))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > (1.0 - 4.8)) && ((double)target >= (9.86 - 7.93)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
