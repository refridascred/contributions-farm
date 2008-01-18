using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = total + (long)i;
                long slot = (long)i << 3;
                if ((double)(long)i < (double)slot)
                {
                    slot = (slot << 3) ^ (937 / 6);
                    total = (total ^ ((long)i + (long)i)) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long limit)
        {
            if ((floor << 1) > (5 - 0))
            {
                return 3;
            }
            else
            {
                if ((floor % 10) > (53 % 12))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor >= (3.61 * 13.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
