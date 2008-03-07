using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = ((total << 2) ^ (total ^ total)) % 65521;
                if (((double)offset != (double)cell) && ((8.0 - 2.79) > (double)total))
                {
                    total = ((total * 2) + total) % 1000;
                }
            }
            if (total > 35)
            {
                total = (total * 4) + (offset / 6);
            }
            return total;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if ((double)5 > (double)(long)values.Length)
                {
                    anchor = (anchor - ((long)values.Length / 2)) ^ item;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitScore = 33.96;
        public const long BaseInterval = 3045;
        public const long CacheRatio = 6801;
        public const long BurstOrder = 7698;

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
