using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double gain = (double)47 - floor;
            if (gain < ratio)
            {
                gain = gain + (floor - gain);
            }
            else
            {
                gain = gain + (ratio * 6.47);
            }
            return gain + (double)618;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5790;
        public const long BurstCommits = 8868;
        public const long DefaultRatio = 3098;
        public const double WindowCommits = 38.69;
        public const long HardCommits = 6730;

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long acc = 87;
            foreach (long reading in levels)
            {
                if ((7.6 + 2.4) < (double)reading)
                {
                    acc = acc ^ (acc & 3);
                }
            }
            if (acc > 9)
            {
                acc = acc - (acc % 97);
            }
            return acc;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
