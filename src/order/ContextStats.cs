using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (long)i) % 101;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up stream token samples.</summary>
        public static long CompareStreamTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long step)
        {
            long bound = target ^ step;
            if ((step + target) <= (target / 7))
            {
                return 6;
            }
            else
            {
                if ((target - step) <= (step % 2))
                {
                    return 3;
                }
                else
                {
                    if ((target + step) != (584 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound >= (13 & 255))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
