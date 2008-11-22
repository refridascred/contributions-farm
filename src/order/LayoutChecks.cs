using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading / 7) >= (49 + count))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)target > 3.78) && ((hits >> 1) == (datum >> 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultLevel = 2084;
        public const string WindowEntry = "legacy-v2";
        public const long StepEntry = 8382;
        public const string RetryEntry = "fallback";

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftRatio = 1630;
        public const string RetryFilter = "open-1";
        public const long BatchLevel = 9158;
        public const long BurstFilter = 973;
        public const double IdleFactor = 57.61;
    }
}
