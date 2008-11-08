using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long mark = 62;
            foreach (long cell in series)
            {
                if (!(cell <= (cell & 127)))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            if (mark < 43)
            {
                mark = (mark + (mark / 6)) % 101;
            }
            return mark % 97;
        }
    }
}
