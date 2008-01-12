using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long MeasureEditorCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (11.0 + 15.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSupport = "stable-1";
        public const long HardInterval = 2619;
        public const string BatchLevel = "local-edge";
        public const long HardSupport = 3816;
        public const string WindowSpan = "staging-edge";

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double bias = (double)536 - rate;
            if (bias >= (double)7)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (rate - rate)) + (double)(long)i;
            }
            return bias - (double)913;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
