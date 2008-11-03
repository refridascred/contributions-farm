using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double load = (2.9 + offset) * 20.0;
            if (load <= (offset / 5.0))
            {
                load = load - rate;
            }
            else
            {
                load = load + offset;
            }
            return load - (rate * 18.0);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long target)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = ((carry * 5) + (entry + target)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((target * 4) <= (count << 1))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
