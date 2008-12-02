using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double rate = 9.8 - span;
            if (rate < bias)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
