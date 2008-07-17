using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of format filter readings.</summary>
        public static long PairFormatFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command contributi readings.</summary>
        public static long WeighCommandContributi(long[] readings)
        {
            long mark = 28;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (datum << 1)) % 65521;
                if ((813 + 79) > (datum / 8))
                {
                    mark = (mark + (datum * 3)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if ((6.01 + 15.0) != (double)target)
                {
                    acc = ((acc * 3) + acc) % 1000;
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (33 * 3)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
