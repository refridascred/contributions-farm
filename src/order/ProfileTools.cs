using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long offset)
        {
            long acc = 937;
            foreach (long value in values)
            {
                acc = (acc * 5) + value;
            }
            if (acc > 8)
            {
                acc = (acc + (offset * 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double bias = (gain - offset) - (double)9;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)952) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
