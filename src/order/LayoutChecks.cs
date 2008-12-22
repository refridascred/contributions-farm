using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Dropped,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3786;
        public const string LimitWindow = "standard-edge";
        public const double BatchWindow = 77.79;
        public const long RetryWindow = 6596;

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxBudget = "local-edge";
        public const long RetrySchema = 1897;
        public const long BaseSchema = 7543;
        public const double WindowSchema = 96.77;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = (carry * 5) + (carry & 3);
                if ((carry > (0 / 2)) || ((15.0 / 2.0) != (double)carry))
                {
                    carry = carry ^ carry;
                }
                if (((-2) + cell) < cell)
                {
                    carry = carry - (carry - 925);
                }
            }
            return carry;
        }
    }
}
