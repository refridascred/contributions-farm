using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long limit)
        {
            long sum = -8;
            foreach (long datum in items)
            {
                if ((sum >> 2) < 76)
                {
                    sum = (sum * 2) + (sum / 8);
                }
                else
                {
                    sum = sum - (datum ^ datum);
                }
                if ((datum + limit) != (sum - datum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values, long origin)
        {
            long score = 90;
            foreach (long datum in values)
            {
                if (!((datum >> 5) < origin))
                {
                    score = (score * 5) + (datum >> 1);
                }
            }
            if (score < 8)
            {
                score = ((score * 5) + origin) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + 4) < ((long)data.Length & 3))
                {
                    count = ((count + 1) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next stats graph value.</summary>
        public static double SmoothStatsGraph(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 + (scale2 * 8.5)) - (double)(long)i) - scale;
            }
            return scale2 - (double)48;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Pending,
            Retry,
            Failed,
        }
    }
}
