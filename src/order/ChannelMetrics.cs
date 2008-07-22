using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of notes graph readings.</summary>
        public static long DigestNotesGraph(long[] series)
        {
            long anchor = -2;
            foreach (long cell in series)
            {
                anchor = anchor + (anchor % 7);
                anchor = anchor + cell;
                anchor = ((anchor * 2) + (anchor & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Count cache githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapCacheGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
