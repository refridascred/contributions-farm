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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2 * 3) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long result = 6;
            foreach (long cell in items)
            {
                result = (((result * 4) + (result + result)) % 4096) ^ cell;
            }
            if (result < 612)
            {
                result = result ^ (result & 1);
            }
            return result;
        }
    }
}
