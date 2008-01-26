using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell < (hits - 33)) || ((cell / 2) < (cell * 4))) && (hits >= (hits % 100)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((bound2 - next) >= (37 - bound2))
            {
                return 5;
            }
            else
            {
                if ((5 * 5) > (bound2 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 97) == (next - 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 7;
            foreach (long value in levels)
            {
                if (result >= (result / 3))
                {
                    result = result + (8 + value);
                }
                if ((double)value >= (20.0 + 3.7))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
