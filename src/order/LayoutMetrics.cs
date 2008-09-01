using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long target)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum * 4) + (sum >> 3)) - target;
                sum = sum + item;
            }
            return sum % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitTimeout = 20.51;
        public const long WindowGithubfarm = 5342;
        public const long MinGithubfarm = 7921;
        public const long MinLevel = 3584;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long target)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (acc > (target * 3))
                {
                    acc = (acc - 5) - item;
                }
                else
                {
                    acc = ((acc << 3) ^ (-76)) % 255;
                }
            }
            return acc;
        }
    }
}
