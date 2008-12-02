using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long limit)
        {
            long next = floor ^ limit;
            if (!(347 < (next + limit)))
            {
                return 1;
            }
            else
            {
                if (next < (next + floor))
                {
                    return 6;
                }
                else
                {
                    if (next <= (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Active,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepBudget = 13.13;
        public const double BaseAlready = 45.74;
        public const string BatchAlready = "legacy-edge";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            New,
        }
    }
}
