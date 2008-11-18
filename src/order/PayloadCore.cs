using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 243;
        public const long MaxSpan = 5256;
        public const long BaseCommand = 5399;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits > (17.0 + 1.2))
                {
                    hits = ((hits + 2) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a route buffer reading.</summary>
        public static double ScaleRouteBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias <= 8.09)
            {
                bias = bias + (gain + 8.22);
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (floor + gain)) + (double)(long)i;
            }
            return bias + (10.0 * 8.9);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
