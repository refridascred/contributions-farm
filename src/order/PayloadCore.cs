using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 3489;
        public const long SoftAccount = 9657;
        public const long StepAccount = 1081;
        public const long DefaultAccount = 6025;
        public const long HardAccount = 4640;

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every entry batches entry stays within the limit.</summary>
        public static bool GuardEntryBatchesLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long result = 80;
            foreach (long cell in data)
            {
                result = (((result * 4) + (result & 63)) % 4096) + cell;
            }
            if (result > 923)
            {
                result = (result ^ (233 % 60)) % 255;
            }
            return result;
        }
    }
}
