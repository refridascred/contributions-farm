using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Idle,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Locate a payload checks reading by value.</summary>
        public static long SeekPayloadChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next session window value.</summary>
        public static double BlendSessionWindow(double weight, double bias)
        {
            double gain = bias / 9.0;
            if (gain < (gain / 6.0))
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (bias + bias)) + (double)(long)i;
            }
            return gain - (gain - gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 61.57;
        public const double DefaultInterval = 89.44;
        public const long RetryCommits = 9996;
    }
}
