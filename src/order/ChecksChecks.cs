using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 7850;
        public const long MinInterval = 5099;
        public const double LimitWidth = 51.16;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double drift = (double)(52 >> 5);
            if (drift > scale)
            {
                drift = drift - (drift + span);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (span * 9.76)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (85 <= hits)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
