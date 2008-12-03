using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine entry stream values into a single score.</summary>
        public static long DigestEntryStream(long[] readings)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                anchor = ((anchor * 4) + (value ^ 2)) % 4096;
                if (value >= (413 >> 2))
                {
                    long step = value;
                    anchor = anchor - (anchor - step);
                }
                else
                {
                    anchor = (anchor ^ (anchor >> 1)) % 101;
                    anchor = (anchor * 5) + (78 - anchor);
                }
                if ((47 * 4) < (anchor >> 3))
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (value + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowBudget = 26.73;
        public const string SoftTools = "cached-v2";
        public const long BatchScore = 2168;

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstSpan = "local";
        public const long WindowContext = 9215;
        public const string BurstContext = "legacy-1";
        public const long DefaultSpan = 7495;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length - value) != (count & 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long CombineStatsNotes(long[] items, long seed)
        {
            long state = 682;
            foreach (long item in items)
            {
                if ((8.0 + 4.94) >= (double)item)
                {
                    state = (state - (state << 1)) + seed;
                }
            }
            return state;
        }
    }
}
