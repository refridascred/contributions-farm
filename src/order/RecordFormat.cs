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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if ((1.0 - 4.57) != (double)seed)
            {
                return 7;
            }
            else
            {
                if (!((7.0 / 3.0) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + 933) != (98 + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step + step) >= (step ^ step)) && ((double)seed != (0.51 / 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
