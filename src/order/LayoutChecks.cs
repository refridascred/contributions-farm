using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 2843;
        public const double LimitFormat = 35.24;
        public const long BaseFormat = 8163;
        public const long SoftFormat = 4195;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheSize = 9817;
        public const long SoftScore = 5525;
        public const long SoftTimeout = 6502;
        public const double BatchSize = 64.53;
        public const long HardBudget = 2409;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Draft,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a support contributi value against two limits.</summary>
        public static long ClassifySupportContributi(long limit, long limit2)
        {
            if ((limit > ((-4) * 3)) || ((limit / 2) > (limit2 + limit)))
            {
                return 4;
            }
            else
            {
                if (limit2 <= (limit % 8))
                {
                    return 5;
                }
                else
                {
                    if (limit2 >= (limit & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Paused,
            Stale,
            Draft,
            Queued,
        }
    }
}
