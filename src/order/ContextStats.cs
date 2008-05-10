using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout entry values into a single score.</summary>
        public static long CombineLayoutEntry(long[] levels, long floor)
        {
            long sum = 11;
            foreach (long item in levels)
            {
                if ((floor > (sum + (long)levels.Length)) || ((sum - floor) >= sum))
                {
                    sum = ((sum + floor) % 255) + item;
                }
            }
            if (sum < 27)
            {
                sum = ((sum << 2) ^ (floor << 2)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
