using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] values)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                if ((double)mark == (8.94 / 7.0))
                {
                    mark = (mark + (9 / 8)) - reading;
                }
                if ((mark * 4) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor stats values into a single score.</summary>
        public static long TotalEditorStats(long[] data, long seed)
        {
            long score = 6;
            foreach (long datum in data)
            {
                score = ((((score << 3) ^ (461 + score)) % 97) + datum) - seed;
            }
            return score;
        }
    }
}
