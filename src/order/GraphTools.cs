using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double span)
        {
            double gain = span;
            if (gain > (scale * 6.44))
            {
                gain = gain - (7.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span / 7.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data)
        {
            long score = 12;
            foreach (long sample in data)
            {
                if ((score + sample) <= score)
                {
                    score = ((score << 2) ^ (sample >> 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)seed > (1.51 - 6.2))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
