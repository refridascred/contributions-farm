using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double mean = (offset * 2.97) + (offset * 13.0);
            if (mean > scale)
            {
                mean = mean + (offset - scale);
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 1.95) + (double)(long)i;
            }
            return mean - (scale + mean);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) < (value % 100)) && (hits <= (hits - value)))
                {
                    hits = hits + 1;
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
