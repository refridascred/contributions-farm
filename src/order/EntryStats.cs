using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a checks order reading.</summary>
        public static double ProjectChecksOrder(double scale, double bias)
        {
            double gain = (double)(264 + (-938));
            if (gain <= (bias - 3.6))
            {
                gain = (gain + bias) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double bias)
        {
            double ratio2 = (bias - bias) * 17.0;
            if (ratio2 < bias)
            {
                ratio2 = (ratio2 - bias) - ratio;
            }
            return ratio2 + 1.6;
        }
    }
}
