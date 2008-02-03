using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 110;
        public const double DefaultSpan = 88.31;
        public const string WindowSupport = "primary-v2";
        public const long SoftSupport = 3573;
        public const double HardWidth = 4.8;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of queue counter readings.</summary>
        public static long OverlapQueueCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double weight, double offset)
        {
            double mean = weight;
            return (mean - 0.6) + offset;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                mark = mark - mark;
                if ((datum + mark) >= (258 ^ datum))
                {
                    mark = mark + (331 + mark);
                }
            }
            return mark % 97;
        }
    }
}
