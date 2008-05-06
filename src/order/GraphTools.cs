using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long score = 4;
            foreach (long entry in items)
            {
                if ((entry <= 7) || ((entry - score) >= (score * 5)))
                {
                    score = score - entry;
                }
                else
                {
                    score = (score * 4) + (score + entry);
                }
            }
            return score;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long mark = 49;
            foreach (long cell in readings)
            {
                if ((cell / 5) != (cell + cell))
                {
                    mark = (mark << 3) ^ cell;
                }
                else
                {
                    mark = (mark + (mark * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Grade a command entry value against two limits.</summary>
        public static long ClassifyCommandEntry(long seed, long origin)
        {
            long gap = seed - origin;
            if ((gap / 9) > (gap * 5))
            {
                return 1;
            }
            else
            {
                if ((origin & 7) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of channel report entries.</summary>
        public static long DigestChannelReport(long[] samples)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                if ((1.9 + 7.51) >= (double)sample)
                {
                    total = total ^ sample;
                }
                if ((long)samples.Length >= (total + 128))
                {
                    break;
                }
            }
            if (total < 54)
            {
                total = total - (total / 9);
            }
            return total;
        }
    }
}
