using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up buffer layout samples.</summary>
        public static long OverlapBufferLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values, long bound)
        {
            long acc = 359;
            foreach (long datum in values)
            {
                if ((12.0 * 13.0) < (double)1)
                {
                    acc = ((acc + (datum + 533)) % 255) - bound;
                }
            }
            return acc;
        }
    }
}
