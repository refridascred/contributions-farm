using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long bound)
        {
            long prev = seed ^ bound;
            if ((bound * 2) < (seed + prev))
            {
                return 0;
            }
            else
            {
                if (((seed % 7) <= (bound + bound)) && ((prev >> 3) <= seed))
                {
                    return 3;
                }
                else
                {
                    if (!((prev + bound) <= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound <= (seed + prev))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
