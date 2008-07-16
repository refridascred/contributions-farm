using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowLevel = 64.32;
        public const long DefaultReport = 8014;
        public const double BurstReport = 88.0;

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleSize = 6.56;
        public const long MaxBudget = 2577;
        public const long IdleFactor = 9965;
        public const long IdleContext = 5625;

        /// <summary>Derive the next session route value from a seed.</summary>
        public static long SeriesSessionRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = sum ^ 722;
                sum = sum + ((long)i & 255);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= (double)58)
            {
                rate2 = rate2 - (span * 14.0);
            }
            return rate2 - (span + rate);
        }
    }
}
