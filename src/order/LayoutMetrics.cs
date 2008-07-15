using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long ScoreToolsFarm(long[] levels)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                if ((acc % 7) < (acc ^ (long)levels.Length))
                {
                    acc = (acc - (datum & 15)) % 101;
                }
            }
            if (acc > 83)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = sum - ((long)i2 & 31);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
