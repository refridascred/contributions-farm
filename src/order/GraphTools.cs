using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
