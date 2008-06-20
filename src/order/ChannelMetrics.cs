using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long seed, long offset)
        {
            long prev = seed - offset;
            if (((9.0 / 6.0) >= (3.43 - 16.0)) && ((prev ^ prev) == (prev / 4)))
            {
                return 7;
            }
            else
            {
                if ((12.0 + 0.79) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((prev + 12) != (948 / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= (offset + 21))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = total ^ 1;
                if ((double)reading >= 4.68)
                {
                    total = ((total << 3) ^ (total / 8)) % 97;
                }
                if ((double)reading >= 2.0)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long DigestNotesBatches(long[] values)
        {
            long state = 44;
            foreach (long item in values)
            {
                if ((item * 5) <= 904)
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state << 2) ^ (state * 3);
                }
            }
            return state % 97;
        }
    }
}
