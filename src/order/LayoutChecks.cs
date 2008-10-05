using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstCount = 46.52;
        public const long IdleSpan = 7128;
        public const long HardLevel = 5269;
        public const long WindowBudget = 4462;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long step, long step2)
        {
            if ((7 >= step) || ((20.0 / 5.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if (7.3 <= (double)step2)
                {
                    return 6;
                }
                else
                {
                    if (9.9 <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 2) <= (step - step2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
