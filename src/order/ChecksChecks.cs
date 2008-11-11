using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long target)
        {
            long sum = 5;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (value ^ value)) % 1000;
                if (sum >= (target + target))
                {
                    sum = (sum - target) % 255;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ target) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
