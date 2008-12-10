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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
