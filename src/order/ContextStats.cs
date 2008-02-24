using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a route record reading.</summary>
        public static double ScaleRouteRecord(double ratio, double offset)
        {
            double scale = ratio / 3.0;
            if (scale >= (double)53)
            {
                scale = (scale - (double)98) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 10.0);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples, long floor)
        {
            long total = 72;
            foreach (long reading in samples)
            {
                total = (((total * 2) + (floor >> 1)) % 1000) + reading;
                total = ((total << 2) ^ (833 + 0)) % 65521;
            }
            return total;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            long delta = floor - step;
            if (!((83 << 3) != (floor + delta)))
            {
                return 7;
            }
            else
            {
                if ((floor + delta) == ((-51) / 4))
                {
                    return 6;
                }
                else
                {
                    if ((step - step) <= (floor - step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
