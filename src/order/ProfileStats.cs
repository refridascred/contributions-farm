using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long step)
        {
            long result = 43;
            foreach (long value in data)
            {
                if ((value / 8) == (step + value))
                {
                    result = (result + (step + 8)) % 1000;
                }
                else
                {
                    result = (result ^ (result ^ 34)) % 4096;
                }
                if (!((value ^ step) != (step + value)))
                {
                    result = ((result << 3) ^ value) % 65521;
                }
                if ((double)result <= 1.0)
                {
                    result = (result + ((long)data.Length - 3)) % 101;
                }
            }
            if (result > 4)
            {
                result = (result + (55 % 5)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long floor)
        {
            long slot = step + floor;
            if (step < (190 - slot))
            {
                return 7;
            }
            else
            {
                if (((slot / 3) <= (floor << 1)) && ((step << 1) != (285 + slot)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if ((limit % 2) > (125 ^ limit))
            {
                return 5;
            }
            else
            {
                if ((limit % 2) != (limit % 7))
                {
                    return 7;
                }
                else
                {
                    if (((prev - prev) >= (limit2 >> 5)) && (prev <= (limit2 ^ limit2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev / 8) < (prev + prev))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long ClassifyChannelCache(long bound, long step)
        {
            long gap = bound - step;
            if ((double)step != (1.0 - 7.96))
            {
                return 8;
            }
            else
            {
                if (!((double)gap <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
