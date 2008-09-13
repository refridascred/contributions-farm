using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of batches command readings.</summary>
        public static long MatchBatchesCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long CountClusterFormatMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < (seen << 1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
