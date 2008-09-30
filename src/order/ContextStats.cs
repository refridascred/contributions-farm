using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double bias = span + (double)516;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (span + bias)) + (double)(long)i) - gain;
            }
            return bias + (span * 8.1);
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data, long target)
        {
            long result = 4;
            foreach (long datum in data)
            {
                if ((target - datum) != (datum >> 5))
                {
                    result = (result * 4) + (8 * 3);
                }
                else
                {
                    result = ((result * 4) + (target + (-95))) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if (4.0 > (double)acc)
                {
                    acc = (acc ^ (offset / 9)) % 255;
                    continue;
                }
                if ((double)offset > (3.4 * 9.27))
                {
                    acc = acc + ((long)i - acc);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
