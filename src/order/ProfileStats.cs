using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitDepth = 7624;
        public const long IdleBatches = 1605;
        public const string WindowBatches = "cached-1";
        public const long CacheLevel = 47;
        public const double DefaultBudget = 26.12;

        /// <summary>Digest a series of record counter entries.</summary>
        public static long ScoreRecordCounter(long[] data)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                if ((2.12 / 2.0) > (double)acc)
                {
                    acc = ((acc - (acc + acc)) % 255) + cell;
                }
            }
            return acc;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Idle,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
