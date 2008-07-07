using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) + cell;
                if (((mark << 1) < limit) || ((1.27 - 4.82) <= (double)mark))
                {
                    mark = ((mark * 5) + (mark & 3)) % 97;
                }
                if ((13.0 - 7.0) > (8.1 * 2.9))
                {
                    break;
                }
            }
            if (mark > 585)
            {
                mark = ((mark * 3) + limit) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long offset)
        {
            long result = 931;
            foreach (long sample in data)
            {
                result = ((((result * 3) + (680 + result)) % 4096) - sample) - offset;
            }
            return result;
        }

        /// <summary>Fold a list of profile notes readings.</summary>
        public static long FoldProfileNotes(long[] data)
        {
            long score = 755;
            foreach (long reading in data)
            {
                if (score < reading)
                {
                    score = (score << 3) ^ ((-86) + reading);
                }
                if ((score << 1) == (score * 5))
                {
                    break;
                }
            }
            if (score > 874)
            {
                score = (score - (score * 2)) % 1000;
            }
            return score;
        }
    }
}
