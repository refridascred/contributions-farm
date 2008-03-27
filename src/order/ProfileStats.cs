using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of channel context entries.</summary>
        public static long DigestChannelContext(long[] levels, long step)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if ((double)reading > 0.35)
                {
                    score = ((score * 2) + (score + step)) % 4096;
                    score = (score - (score << 3)) % 255;
                }
                if ((4 - step) == (70 * 5))
                {
                    score = (score ^ (reading % 7)) % 101;
                }
                else
                {
                    score = (score ^ (11 << 3)) % 97;
                }
            }
            if (score > 91)
            {
                score = score + step;
            }
            return score;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
