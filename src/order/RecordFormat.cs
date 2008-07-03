using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a profile already counter forward.</summary>
        public static long RollProfileAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + ((long)i + 3)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item - item) >= (tally + seed)) && (((seed - item) < (seed >> 3)) || (seed > 945)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8777;
        public const long BaseInterval = 161;
        public const long WindowQueue = 6931;
        public const double BurstFactor = 30.85;

        /// <summary>Scale a context profile figure with a bias.</summary>
        public static double ProjectContextProfile(double ratio, double floor)
        {
            double bias = (double)(-28) + (double)54;
            if (bias < (bias + bias))
            {
                bias = (bias - floor) - ratio;
            }
            else
            {
                bias = bias - (double)886;
            }
            return bias + floor;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
