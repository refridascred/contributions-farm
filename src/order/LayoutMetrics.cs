using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel metric readings.</summary>
        public static long FoldChannelMetric(long[] values, long floor)
        {
            long result = 111;
            foreach (long entry in values)
            {
                result = (result ^ (111 ^ entry)) - floor;
            }
            if (result > 343)
            {
                result = ((result * 3) + (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 3) ^ (seed + seed);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
