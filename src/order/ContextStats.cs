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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long span = (result & 1) - result;
                    result = ((result * 3) + (result + span)) ^ (long)i2;
                }
                result = (result ^ (result + result)) % 97;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
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
