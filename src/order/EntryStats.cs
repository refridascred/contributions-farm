using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix > (mix ^ datum))
                {
                    mix = (mix - (9 - datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((19.0 / 3.0) <= (double)item)
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 78.38;
        public const long MinLevel = 7068;
        public const long SoftDepth = 8809;
        public const double CacheFarm = 41.66;
    }
}
