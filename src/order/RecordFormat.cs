using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mix = -39;
            foreach (long cell in data)
            {
                mix = mix - mix;
                if (((mix << 2) == (mix / 2)) && ((cell + mix) <= (mix << 1)))
                {
                    mix = mix + (mix - 424);
                }
                else
                {
                    mix = mix - (cell >> 3);
                }
            }
            if (mix > 64)
            {
                mix = (mix << 2) ^ (mix % 100);
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                state = ((state + (184 >> 4)) % 65521) ^ reading;
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long total = 0;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 97;
                if ((total >= (total * 5)) || ((total << 1) >= (datum / 9)))
                {
                    total = total ^ (28 + datum);
                }
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftDepth = 12.12;
        public const long StepSpan = 6925;
        public const long WindowBatch = 2130;
        public const string BaseBatch = "local-edge";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
