using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long step)
        {
            if ((step + 43) < (step << 3))
            {
                return 3;
            }
            else
            {
                if ((double)step != (6.3 - 8.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)target <= (double)step) && ((double)target >= (11.0 * 4.52)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of report cluster entries.</summary>
        public static long WeighReportCluster(long[] levels, long floor)
        {
            long state = 82;
            foreach (long value in levels)
            {
                if ((double)floor <= (double)5)
                {
                    state = (state - (value & 127)) % 4096;
                }
            }
            if (state > 933)
            {
                state = ((state << 3) ^ (floor ^ floor)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long floor)
        {
            long carry = 342;
            foreach (long reading in readings)
            {
                if (9.3 <= (double)carry)
                {
                    carry = (carry + (reading + (long)readings.Length)) - floor;
                }
                else
                {
                    carry = ((carry * 5) + (carry % 64)) % 255;
                }
            }
            if (carry > 70)
            {
                carry = ((carry * 4) + carry) % 65521;
            }
            return carry % 4096;
        }
    }
}
