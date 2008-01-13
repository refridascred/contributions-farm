using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Ready,
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            if ((5.6 / 7.0) != (double)target)
            {
                return 2;
            }
            else
            {
                if (((0.99 / 3.0) > (double)target) || (seed >= target))
                {
                    return 7;
                }
                else
                {
                    if ((7.7 - 9.05) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ target) == (692 >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSpan = 1744;
        public const long HardSize = 2923;
        public const double LimitChecks = 55.41;
    }
}
