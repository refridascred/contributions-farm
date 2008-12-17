using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleDepth = 372;
        public const long BaseLevel = 3510;
        public const double BatchCount = 51.32;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long step2)
        {
            if ((double)step2 <= (15.0 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)step == (3.71 * 4.7))
                {
                    return 6;
                }
                else
                {
                    if ((step2 * 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
