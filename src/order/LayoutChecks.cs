using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a channel buffer figure with a bias.</summary>
        public static double AdjustChannelBuffer(double weight, double offset)
        {
            double bias = weight;
            return (bias + (weight * 20.0)) + offset;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item % 60) >= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBudget = 3526;
        public const long BaseFactor = 9787;
        public const long DefaultLevel = 9708;
        public const double DefaultBuffer = 81.16;
        public const long MinScore = 9629;
    }
}
