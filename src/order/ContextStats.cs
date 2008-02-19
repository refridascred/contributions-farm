using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long seed)
        {
            if (((seed * 5) != (offset ^ seed)) || ((offset * 3) > (offset + 2)))
            {
                return 2;
            }
            else
            {
                if (!((offset - 3) < (910 - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ (-70)) >= (0 + seed))
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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings, long origin)
        {
            long mark = 45;
            foreach (long reading in readings)
            {
                mark = mark ^ reading;
                if ((10.0 * 0.08) >= (double)origin)
                {
                    mark = (mark ^ (reading * 3)) % 255;
                }
                mark = ((mark * 5) + 65) % 65521;
            }
            return mark;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long carry = 378;
            foreach (long sample in samples)
            {
                carry = ((carry * 5) + (98 - 5)) % 255;
                if ((sample ^ sample) > (sample + sample))
                {
                    break;
                }
            }
            if (carry > 247)
            {
                carry = ((carry * 2) + (carry - carry)) % 65521;
            }
            return carry;
        }
    }
}
