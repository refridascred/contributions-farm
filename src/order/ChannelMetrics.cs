using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long limit)
        {
            long lane = step - limit;
            if ((step % 100) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)lane <= 5.56)
                {
                    return 5;
                }
                else
                {
                    if ((step & 15) != (step % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
