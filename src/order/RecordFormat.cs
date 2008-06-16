using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 1028;
        public const double BaseStats = 82.17;
        public const long WindowCount = 4432;
        public const long MinDepth = 4468;
        public const long BurstSize = 9921;

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 43.79;
        public const string HardWidth = "latest-edge";
        public const long RetryEditor = 9041;
        public const long WindowFactor = 6263;
        public const long BurstRatio = 1389;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((0.74 - 3.8) > (double)(long)i)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally / 9) <= (tally ^ (long)levels.Length)) || !((tally ^ datum) < (datum - (-738))))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long seed)
        {
            if ((double)limit == (5.0 + 9.7))
            {
                return 8;
            }
            else
            {
                if ((11.0 + 1.6) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((1.65 + 7.1) > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
