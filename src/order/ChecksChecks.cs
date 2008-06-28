using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double drift = (3.0 + scale) + (offset - scale);
            if (drift <= (double)0)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - scale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 8569;
        public const long MaxFarm = 8468;
        public const string BatchCount = "standard-1";
        public const double IdleFarm = 75.35;
    }
}
