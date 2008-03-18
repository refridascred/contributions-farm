using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of counter channel entries.</summary>
        public static long ScoreCounterChannel(long[] series, long origin)
        {
            long result = 434;
            foreach (long item in series)
            {
                result = ((result << 2) ^ (result * 5)) - origin;
                result = (result ^ (item / 8)) % 4096;
            }
            if (result < 7)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result % 97;
        }

        /// <summary>Grade a metric token value against two limits.</summary>
        public static long SortMetricToken(long step, long bound)
        {
            long edge = step - bound;
            if ((step & 1) <= (step / 4))
            {
                return 1;
            }
            else
            {
                if (!((edge - 6) == (8 ^ step)))
                {
                    return 0;
                }
                else
                {
                    if ((double)edge > 8.8)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long MeasureGithubfarmCacheHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (count + cell))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
