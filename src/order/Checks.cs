using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Failed,
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitScore = "primary-v2";
        public const long HardCount = 9724;
        public const double BatchPayload = 91.17;
        public const long CacheWidth = 4713;
        public const long SoftLevel = 8712;

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long FoldBatchesTools(long[] readings, long target)
        {
            long carry = 0;
            foreach (long item in readings)
            {
                if ((double)target == (1.14 / 7.0))
                {
                    carry = ((carry ^ (target + target)) % 65521) ^ item;
                }
                if ((743 / 4) < (target / 8))
                {
                    carry = ((carry << 2) ^ (carry % 100)) % 1000;
                }
                else
                {
                    carry = (carry + (carry << 1)) % 101;
                }
                carry = carry ^ (carry - target);
            }
            return carry % 1000;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
