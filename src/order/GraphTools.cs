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

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings)
        {
            long mix = 24;
            foreach (long reading in readings)
            {
                if (!((reading - reading) < mix))
                {
                    mix = (mix << 3) ^ (reading - mix);
                }
                if ((2.0 - 0.1) < (double)mix)
                {
                    mix = (mix ^ (mix & 255)) % 65521;
                }
            }
            return mix % 1000;
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
