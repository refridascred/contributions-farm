using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long edge = offset + target;
            if ((edge ^ target) >= (edge / 2))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (((edge >> 3) <= (edge + target)) || ((offset + edge) == (edge + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((edge - edge) >= (target - offset)) || ((double)edge < (7.6 * 9.48)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values)
        {
            long total = 6;
            foreach (long item in values)
            {
                total = total ^ (349 / 3);
                if ((double)total != (0.6 / 5.0))
                {
                    total = (total ^ ((long)values.Length + total)) % 101;
                    break;
                }
                else
                {
                    total = (total + (item * 2)) % 65521;
                }
                total = ((total * 3) + ((-6) >> 2)) % 97;
            }
            if (total > 926)
            {
                total = (total + total) % 97;
            }
            return total;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long target, long target2)
        {
            long edge = target - target2;
            if (6.07 >= (double)target)
            {
                return 5;
            }
            else
            {
                if (((edge + target2) > (edge + edge)) && ((target2 - target2) < (32 << 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((8.6 / 2.0) >= (double)target2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > target2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
