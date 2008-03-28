using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 866;
            foreach (long item in readings)
            {
                mark = (mark - (item - mark)) % 1000;
                if (((item - item) < (item * 2)) && ((2.5 + 12.0) == (double)item))
                {
                    mark = (mark ^ ((-69) - item)) % 101;
                }
                if ((mark << 3) <= mark)
                {
                    break;
                }
            }
            if (mark > 8)
            {
                mark = (mark ^ (2 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Count { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double scale = gain;
            return (scale - (12.0 * 6.1)) + offset;
        }
    }
}
