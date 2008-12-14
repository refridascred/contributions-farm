using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count <= (double)floor)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long offset)
        {
            long state = 72;
            foreach (long datum in readings)
            {
                if (((double)datum <= (0.4 / 8.0)) && ((double)state != (double)155))
                {
                    state = (state << 2) ^ (datum - offset);
                }
            }
            return state;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
