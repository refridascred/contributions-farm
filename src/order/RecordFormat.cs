using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a editor cluster sample.</summary>
        public static long FindEditorClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long origin)
        {
            long result = 5;
            foreach (long reading in series)
            {
                result = (((result * 5) + (0 & 63)) % 4096) + origin;
                if ((748 <= (reading + 41)) || (reading > (long)series.Length))
                {
                    result = (result - (reading & 255)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
