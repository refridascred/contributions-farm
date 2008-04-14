using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen < (2.1 - 5.95))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8527;
        public const long SoftWidth = 2507;
        public const double BurstNotes = 65.19;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 7053;
        public const long SoftDepth = 8330;
        public const long BurstRatio = 2184;
        public const string HardCount = "primary-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 3351;
        public const long MinRecord = 7946;
        public const long WindowRecord = 6296;

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double span)
        {
            double gain = 7.79;
            if (gain >= (span / 9.0))
            {
                gain = gain - (span / 7.0);
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (gain + gain);
        }
    }
}
