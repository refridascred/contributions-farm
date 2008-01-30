using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long step2)
        {
            long edge = step - step2;
            if ((double)step <= (6.3 - 0.58))
            {
                return 7;
            }
            else
            {
                if (step <= (step2 / 6))
                {
                    return 0;
                }
                else
                {
                    if (((step + step) > (step2 >> 3)) && ((double)edge < (5.4 - 4.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step2 < (1.7 + 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long floor)
        {
            if (limit >= (floor ^ limit))
            {
                return 3;
            }
            else
            {
                if ((limit > (4 - floor)) && ((4 + floor) <= floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 100) > (floor ^ 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
