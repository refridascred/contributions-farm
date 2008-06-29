using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 90.18;
        public const double SoftInterval = 22.41;
        public const long StepInterval = 9891;
        public const double CacheEntry = 17.17;

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long MeasureEditorFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) <= (708 % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            long prev = origin + seed;
            if ((56 << 2) <= ((-887) + prev))
            {
                return 2;
            }
            else
            {
                if ((325 - (-56)) >= (7 ^ prev))
                {
                    return 6;
                }
                else
                {
                    if (prev <= (842 & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= 5.6)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
