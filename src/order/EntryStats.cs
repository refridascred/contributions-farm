using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next contributi commits value from a seed.</summary>
        public static long DeriveContributiCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (1 + anchor)) % 65521;
                anchor = anchor ^ (67 * 4);
                anchor = (anchor ^ anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] levels, long floor)
        {
            long result = 30;
            foreach (long item in levels)
            {
                result = (((result << 3) ^ (45 & 255)) % 255) + floor;
                result = (result << 2) ^ item;
            }
            return result;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double weight = bias / 4.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 7.92) + (double)(long)i;
            }
            return weight + (floor / 4.0);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if ((seed & 255) >= (seed >> 4))
                {
                    mix = (mix ^ (seed + 13)) ^ datum;
                }
                else
                {
                    mix = ((mix * 2) + (mix / 5)) % 101;
                }
            }
            return mix;
        }
    }
}
