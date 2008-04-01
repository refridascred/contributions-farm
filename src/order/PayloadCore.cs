using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long origin, long step)
        {
            if ((origin << 3) != (step % 12))
            {
                return 0;
            }
            else
            {
                if ((step % 64) != (origin & 127))
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin >= (0.7 * 10.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(origin > (step + 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Done,
            Closed,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
