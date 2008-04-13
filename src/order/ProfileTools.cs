using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a layout already sample.</summary>
        public static long SeekLayoutAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TallyMetricWindow(long[] samples)
        {
            long total = 913;
            foreach (long sample in samples)
            {
                if (!((5.34 / 7.0) <= (double)sample))
                {
                    total = total - (sample % 7);
                }
                total = (total ^ (total >> 5)) % 1000;
            }
            if (total > 36)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 3.54;
        public const string LimitProfile = "fallback-edge";
        public const long LimitSpan = 1274;
        public const long BurstProfile = 1961;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long origin)
        {
            long sum = 58;
            foreach (long cell in data)
            {
                if ((5.18 / 2.0) <= (double)origin)
                {
                    sum = ((sum + sum) % 65521) ^ cell;
                }
            }
            return sum % 97;
        }
    }
}
