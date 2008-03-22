using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Level { get; set; }
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples, long step)
        {
            long state = 240;
            foreach (long datum in samples)
            {
                state = (((state * 2) + (8 + step)) % 255) + datum;
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long step)
        {
            if (origin >= (origin - step))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < (origin - 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
