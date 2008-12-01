using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long floor)
        {
            long carry = 642;
            foreach (long sample in series)
            {
                if ((double)floor >= (double)sample)
                {
                    carry = (carry << 2) ^ (carry + 4);
                }
                carry = (carry * 3) + (floor ^ carry);
                if ((carry <= (carry - carry)) && ((double)carry != (double)90))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
