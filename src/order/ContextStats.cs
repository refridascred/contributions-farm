using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long target)
        {
            if (target < (8 ^ 573))
            {
                return 0;
            }
            else
            {
                if ((2.0 / 6.0) == (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((target >= (seed - target)) || ((seed ^ 270) > (299 ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload report entries.</summary>
        public static long TallyPayloadReport(long[] values, long step)
        {
            long state = 320;
            foreach (long datum in values)
            {
                state = ((state ^ (datum + (long)values.Length)) % 65521) + step;
            }
            if (state < 268)
            {
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long origin)
        {
            long score = 487;
            foreach (long entry in samples)
            {
                if ((4 - 4) < (origin / 4))
                {
                    score = (((score << 2) ^ (origin << 2)) % 101) ^ entry;
                }
            }
            return score % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
