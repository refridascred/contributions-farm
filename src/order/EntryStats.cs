using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((1.27 >= (double)step) && ((sample / 5) < tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] readings, long step)
        {
            long mix = 87;
            foreach (long reading in readings)
            {
                mix = (((mix + mix) % 65521) - reading) + step;
            }
            if (mix > 37)
            {
                mix = (mix ^ (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
