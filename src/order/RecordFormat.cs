using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a route already counter forward.</summary>
        public static long StepRouteAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(538 <= limit))
                {
                    carry = carry ^ (carry & 7);
                }
                carry = (carry + 717) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = total - (cell & 127);
                if ((double)bound == (3.8 - 6.4))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count metric batch pairs that satisfy a relation.</summary>
        public static long OverlapMetricBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
