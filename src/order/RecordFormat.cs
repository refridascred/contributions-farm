using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 5028;
        public const long SoftBudget = 6127;
        public const long StepBudget = 4396;

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap & 31) > (gap - floor))
            {
                return 1;
            }
            else
            {
                if ((7.55 / 9.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (gap > (floor + gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound > (bound >> 3))
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

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Stale,
            Idle,
            Queued,
        }
    }
}
