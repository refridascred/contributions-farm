using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long step2)
        {
            if ((step2 ^ step2) > 87)
            {
                return 6;
            }
            else
            {
                if ((step2 & 255) >= step)
                {
                    return 5;
                }
                else
                {
                    if (step2 > (step2 ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step2 << 3) != (374 >> 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples, long step)
        {
            long state = 6;
            foreach (long value in samples)
            {
                state = (((state ^ state) % 65521) - value) - step;
                state = (state + state) % 101;
            }
            if (state < 0)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((30 / 4) != (sample - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
