using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long bound)
        {
            long mark = 13;
            foreach (long reading in levels)
            {
                if (950 > mark)
                {
                    mark = ((mark * 5) + 697) ^ reading;
                }
            }
            if (mark > 696)
            {
                mark = ((mark << 3) ^ (bound ^ 62)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
