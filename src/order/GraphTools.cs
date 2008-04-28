using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long result = 540;
            foreach (long reading in items)
            {
                bool found = result >= (624 + result);
                if (!found)
                {
                    found = (result <= (result + reading)) || ((reading >> 5) == (result + 2));
                }
                if (((double)result <= (double)reading) && ((reading & 31) <= result))
                {
                    result = (result ^ (result / 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 3) ^ (mark + step);
                if ((step + step) == (step + (long)i))
                {
                    mark = (mark + (step + mark)) % 4096;
                }
                mark = (mark << 2) ^ step;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many metrics channel samples are out of range.</summary>
        public static long CountMetricsChannelOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((limit - limit) <= (107 ^ 125))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
