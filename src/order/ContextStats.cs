using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((-3) & 127) < (state >> 5))
                {
                    state = ((state << 2) ^ (bound << 2)) % 101;
                    state = state ^ (bound >> 1);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values, long step)
        {
            long mix = 443;
            foreach (long datum in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (mix + ((long)i / 8)) % 1000;
                }
                if ((step << 3) < datum)
                {
                    mix = (mix - datum) % 1000;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long limit)
        {
            if ((offset / 7) > (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) <= (769 * 2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3 & 127) < hits)
                {
                    hits = ((hits + 1) - reading) - bound;
                }
            }
            return hits;
        }
    }
}
