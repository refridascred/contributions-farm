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

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a farm editor figure with a bias.</summary>
        public static double AdjustFarmEditor(double ratio, double span)
        {
            double mean = (double)((-294) + 98);
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - mean) - (double)(long)i) + ratio) + span;
            }
            return mean - 2.36;
        }
    }
}
