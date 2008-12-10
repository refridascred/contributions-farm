using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long target, long bound)
        {
            if (((double)target != (3.5 * 6.81)) || (bound > target))
            {
                return 7;
            }
            else
            {
                if (((bound + target) >= (target >> 3)) || (bound <= (bound & 127)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
