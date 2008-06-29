using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long TallyCounterFarm(long[] items, long seed)
        {
            long mark = 692;
            foreach (long value in items)
            {
                if ((seed % 2) >= (seed - 826))
                {
                    mark = ((mark << 2) ^ 588) - value;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] levels)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 2) ^ (anchor - 54)) % 255) + reading;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
