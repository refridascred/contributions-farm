using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long limit)
        {
            long next = target - limit;
            if ((target > (80 - target)) || ((next - target) == (216 << 1)))
            {
                return 7;
            }
            else
            {
                if (!((limit & 63) > (limit - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((double)target > (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit & 127) >= (limit * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long offset, long limit)
        {
            if ((double)offset <= 8.17)
            {
                return 4;
            }
            else
            {
                if ((offset - offset) < (2 + limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Idle,
            Done,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = score ^ (bound * 2);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepBudget = "cached-edge";
        public const long HardDepth = 8874;
        public const long HardOrder = 7050;
        public const long RetryOrder = 6124;
        public const long HardRatio = 9647;
    }
}
