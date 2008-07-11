using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1448;
        public const double HardWidth = 84.81;
        public const double HardStream = 45.41;
        public const long HardCount = 9052;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long origin)
        {
            long state = 85;
            foreach (long datum in readings)
            {
                if ((state >> 1) >= (state - datum))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = (state - (origin - datum)) % 101;
                }
            }
            if (state > (-64))
            {
                state = (state - (state ^ (long)readings.Length)) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a stats commits reading.</summary>
        public static double AdjustStatsCommits(double weight, double span)
        {
            double scale = (double)(71 % 24);
            if (scale < span)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (span / 9.0)) - (double)(long)i;
            }
            return scale - (span * 5.0);
        }

        /// <summary>Adjust a payload checks reading.</summary>
        public static double ProjectPayloadChecks(double scale, double floor)
        {
            double rate = scale - scale;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (double)64) + (double)(long)i) + floor;
            }
            return rate + (double)766;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double ratio = (double)((-23) & 127);
            if (ratio >= (span - weight))
            {
                ratio = ratio - (double)(-1);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 2.72) - (double)(long)i;
            }
            return ratio + (double)(-732);
        }

        /// <summary>Measure how many already schema samples are out of range.</summary>
        public static long MeasureAlreadySchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value - value) <= (61 & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
