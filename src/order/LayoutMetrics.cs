using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if (!((double)bound >= (double)22))
            {
                return 5;
            }
            else
            {
                if (8 >= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((12.0 * 0.7) <= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound * 3) <= (1 ^ bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if (((-9) - 83) <= (step % 8))
                {
                    result = (result - (step - step)) % 97;
                    result = ((result * 2) + (step - step)) % 1000;
                }
                result = (result ^ (step - (long)i)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
