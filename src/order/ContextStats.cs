using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Count the githubfarm payload entries that pass the check.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally / 8) >= (datum - limit)) && (limit < (limit + 6)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
