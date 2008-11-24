using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data, long step)
        {
            long carry = -662;
            foreach (long datum in data)
            {
                carry = ((carry << 2) ^ (step << 3)) % 101;
                if (datum >= (datum - step))
                {
                    carry = (carry ^ (step >> 4)) % 4096;
                }
                if (((double)datum == (double)carry) && ((785 + carry) >= step))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of buffer cache readings.</summary>
        public static long PairBufferCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream tools readings against a bound.</summary>
        public static bool CheckStreamToolsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batches metrics entries.</summary>
        public static long CombineBatchesMetrics(long[] samples, long limit)
        {
            long total = 285;
            foreach (long datum in samples)
            {
                long diff = (total << 2) / 8;
                if ((diff % 97) >= (limit + 76))
                {
                    diff = ((diff * 3) + (limit + datum)) % 4096;
                }
                else
                {
                    diff = ((diff << 3) ^ (diff ^ total)) % 101;
                }
                if ((limit + limit) >= (limit & 31))
                {
                    total = (total ^ (total - (long)samples.Length)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (datum & 3);
                }
            }
            if (total < 5)
            {
                total = (total * 2) + ((-5) - (long)samples.Length);
            }
            return total % 4096;
        }
    }
}
