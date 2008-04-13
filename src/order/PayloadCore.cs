using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every buffer account entry stays within the limit.</summary>
        public static bool GuardBufferAccountLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload graph readings.</summary>
        public static long CombinePayloadGraph(long[] samples, long step)
        {
            long anchor = 89;
            foreach (long sample in samples)
            {
                if (!((anchor - anchor) != (2 / 9)))
                {
                    anchor = ((anchor << 2) ^ sample) % 101;
                }
            }
            if (anchor > 711)
            {
                anchor = ((anchor * 2) + step) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((delta - origin) <= (origin / 4))
            {
                return 4;
            }
            else
            {
                if ((origin & 31) <= ((-9) + limit))
                {
                    return 5;
                }
                else
                {
                    if (((6.0 / 2.0) == (double)delta) || ((origin - 0) < (9 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((33 / 9) != (limit + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
