using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long step)
        {
            long cur = target ^ step;
            if (0.97 >= (double)cur)
            {
                return 4;
            }
            else
            {
                if ((39 * 5) <= target)
                {
                    return 5;
                }
                else
                {
                    if (((double)target <= (5.1 * 4.2)) || ((cur << 3) != (target & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step * 3) > (step & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long ClassifyRecordCounter(long step, long step2)
        {
            long gap = step - step2;
            if ((step2 % 64) <= (gap / 4))
            {
                return 1;
            }
            else
            {
                if (step > (gap ^ 8))
                {
                    return 0;
                }
                else
                {
                    if ((4.83 / 2.0) != (double)gap)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples, long offset)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((offset & 7) >= (value + acc))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = (acc ^ (offset ^ 692)) % 255;
                }
                if ((offset - offset) <= (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 2) ^ (seed - total)) % 255) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
