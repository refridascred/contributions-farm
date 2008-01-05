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

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((floor - 151) < (item * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
