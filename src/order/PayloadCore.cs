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

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
