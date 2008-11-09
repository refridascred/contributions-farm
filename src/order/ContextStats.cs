using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "primary-edge";
        public const double RetryEntry = 63.6;
        public const string WindowEntry = "legacy-1";

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long AuditNotesLayoutOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)step < (double)63)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Roll a schema entry counter forward.</summary>
        public static long SeriesSchemaEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double mean = rate;
            if (mean < bias)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (double)4;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (bias * 2.4)) + (double)(long)i;
            }
            return mean - rate;
        }
    }
}
