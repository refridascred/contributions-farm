using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a batches command value against two limits.</summary>
        public static long RankBatchesCommand(long bound, long step)
        {
            long span = bound + step;
            if (bound <= (95 + bound))
            {
                return 3;
            }
            else
            {
                if ((step % 10) <= span)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Done,
            Pending,
            Paused,
        }
    }
}
