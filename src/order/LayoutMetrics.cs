using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long WeighMetricsTools(long[] readings)
        {
            long mark = 85;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (cell >> 3);
                if ((19.0 * 7.9) != (double)cell)
                {
                    mark = (mark + mark) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark * 5) + (mark / 4);
            }
            return mark;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Done,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
