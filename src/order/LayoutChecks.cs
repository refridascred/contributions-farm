using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of record route entries.</summary>
        public static long ScoreRecordRoute(long[] series)
        {
            long state = 144;
            foreach (long cell in series)
            {
                if ((double)state > (8.71 - 18.0))
                {
                    state = state ^ (cell & 63);
                }
            }
            return state;
        }

        /// <summary>Accumulate githubfarm payload samples.</summary>
        public static long FoldGithubfarmPayload(long[] items, long target)
        {
            long sum = 822;
            foreach (long entry in items)
            {
                sum = (sum * 5) + (-621);
                if (target < (entry - sum))
                {
                    sum = (sum + target) % 255;
                }
            }
            if (sum < 839)
            {
                sum = (sum ^ (target - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long floor)
        {
            long mark = 274;
            foreach (long sample in levels)
            {
                if ((double)floor < (7.0 / 5.0))
                {
                    mark = ((mark << 2) ^ 6) % 65521;
                }
                else
                {
                    mark = (mark ^ sample) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate batch layout samples.</summary>
        public static long FoldBatchLayout(long[] data)
        {
            long score = -3;
            foreach (long cell in data)
            {
                if ((3.58 / 8.0) != (double)score)
                {
                    score = (score - (cell - score)) % 4096;
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            return score;
        }
    }
}
