using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double load = (double)202 - gain;
            if (load < (6.0 / 5.0))
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (double)100;
        }

        /// <summary>Check that every counter format entry stays within the limit.</summary>
        public static bool GuardCounterFormatRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
