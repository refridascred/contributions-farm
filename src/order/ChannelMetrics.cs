using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseCount = 5.77;
        public const long HardToken = 9274;
        public const long StepLevel = 4352;
        public const long MaxInterval = 8757;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((7.86 > (double)cell) && (cell > (hits % 60))) && (((floor & 15) <= floor) && ((hits + hits) < (hits - hits))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
