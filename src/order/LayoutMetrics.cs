using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long step, long origin)
        {
            if ((double)step > (5.7 * 1.5))
            {
                return 2;
            }
            else
            {
                if (2.0 < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((origin > (26 ^ origin)) && (step >= 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + origin) > 1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchInterval = 8.07;
        public const double RetrySpan = 72.77;
        public const double MinBatch = 39.81;
        public const double StepBatch = 53.42;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
