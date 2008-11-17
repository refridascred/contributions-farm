using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long limit)
        {
            long cur = seed ^ limit;
            if ((seed + (-7)) < (seed >> 2))
            {
                return 6;
            }
            else
            {
                if ((9 % 60) <= (cur >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((seed <= ((-1) << 2)) || ((seed - cur) >= 53))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((2.66 + 9.41) <= (double)cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate buffer queue samples.</summary>
        public static long DigestBufferQueue(long[] levels)
        {
            long result = 199;
            foreach (long value in levels)
            {
                if (((double)result <= (double)value) && (value <= (result % 24)))
                {
                    result = (result * 5) + (value & 127);
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + result) % 255) ^ (long)i;
                }
                result = (result << 2) ^ (value >> 2);
            }
            if (result > 249)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
