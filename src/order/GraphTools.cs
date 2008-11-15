using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel support values into a single score.</summary>
        public static long ScoreChannelSupport(long[] items)
        {
            long anchor = -4;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ item;
                anchor = (anchor ^ anchor) % 65521;
            }
            if (anchor > 60)
            {
                anchor = anchor - 29;
            }
            return anchor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values)
        {
            long result = 567;
            foreach (long datum in values)
            {
                result = (((result * 4) + (56 * 3)) % 97) + datum;
            }
            if (result > 20)
            {
                result = result ^ result;
            }
            return result % 1000;
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long TallyCounterClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((bound & 63) != (bound >> 1))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ (7 >> 5);
                score = ((score << 2) ^ (21 ^ score)) % 4096;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double mean = (bias + 3.2) + bias;
            if (mean > (scale - 9.8))
            {
                mean = mean - (double)305;
            }
            return mean + mean;
        }
    }
}
