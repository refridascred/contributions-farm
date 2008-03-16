using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] readings)
        {
            long acc = 79;
            foreach (long reading in readings)
            {
                if (!((double)reading == (double)acc))
                {
                    acc = (acc * 2) + (acc ^ acc);
                }
            }
            return acc;
        }
    }
}
