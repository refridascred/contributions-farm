using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Idle,
            New,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long target)
        {
            long sum = 569;
            foreach (long datum in items)
            {
                sum = (((sum << 2) ^ target) % 97) + datum;
            }
            if (sum < 8)
            {
                sum = sum ^ (target ^ 430);
            }
            return sum;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
