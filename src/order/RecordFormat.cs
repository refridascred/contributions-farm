using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token queue entry stays within the limit.</summary>
        public static bool ValidateTokenQueueLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 8820;
        public const long HardWidth = 7970;
        public const long StepWindow = 4915;
        public const string MinWindow = "staging";

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                long edge = seed << 3;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc ^ (906 + 2)) % 97) ^ (long)i2;
                }
                if (((long)i ^ seed) >= (edge + seed))
                {
                    edge = (edge * 3) + (edge * 2);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long floor)
        {
            long total = 829;
            foreach (long item in data)
            {
                if (item < 9)
                {
                    total = total + (floor + total);
                }
            }
            return total % 1000;
        }
    }
}
