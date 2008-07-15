using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long mark = -35;
            foreach (long cell in series)
            {
                mark = (((mark * 5) + (mark << 3)) % 65521) ^ cell;
            }
            return mark;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long bound)
        {
            long score = 29;
            foreach (long item in data)
            {
                if ((item - 7) <= (2 + bound))
                {
                    score = ((score * 4) + (bound >> 4)) % 97;
                }
            }
            if (score > 534)
            {
                score = (score * 5) + (bound - score);
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchInterval = 63.44;
        public const long HardFilter = 1869;
        public const double StepRatio = 36.68;

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long acc = 125;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ entry) % 1000;
                acc = (acc << 2) ^ ((long)samples.Length + acc);
                if (((entry ^ acc) >= entry) || ((6 & 127) < (acc / 8)))
                {
                    acc = ((acc << 3) ^ (acc / 3)) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long WeighRecordPayload(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                if (!((876 / 7) != (state >> 5)))
                {
                    state = (state << 3) ^ (item % 12);
                    break;
                }
                if ((item + 78) == (item / 9))
                {
                    state = (state - (item % 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }
    }
}
