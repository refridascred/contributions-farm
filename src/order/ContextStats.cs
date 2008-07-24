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

        /// <summary>Derive the next account metrics value from a seed.</summary>
        public static long DeriveAccountMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = result + ((long)i & 31);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
