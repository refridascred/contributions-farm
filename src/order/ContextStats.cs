using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long limit)
        {
            if (!((bound ^ 2) >= (bound * 4)))
            {
                return 1;
            }
            else
            {
                if ((limit / 5) == (bound / 4))
                {
                    return 2;
                }
                else
                {
                    if (((2.51 - 9.25) == (double)bound) || ((400 - limit) < (limit * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 86;
            foreach (long entry in values)
            {
                mix = (mix + (entry + mix)) % 101;
                if (!((double)mix != (4.0 / 7.0)))
                {
                    mix = (mix + (mix << 2)) % 255;
                    mix = mix + 988;
                }
                if ((mix + entry) >= (mix + 21))
                {
                    mix = (mix << 3) ^ (entry * 3);
                }
            }
            if (mix < 964)
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((double)cell <= (8.0 + 0.4)) || ((451 + 31) > (cell / 4))))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
