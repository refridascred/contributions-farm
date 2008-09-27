using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long step, long bound)
        {
            long delta = step ^ bound;
            if ((4.1 + 6.0) > (double)delta)
            {
                return 5;
            }
            else
            {
                if ((double)step <= (9.1 - 6.65))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
