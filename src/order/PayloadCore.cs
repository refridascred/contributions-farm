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

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 96.65;
        public const double MinTimeout = 12.45;
        public const long MaxTimeout = 2014;
        public const long IdleAlready = 3228;
        public const string BaseBudget = "cached-v2";
    }
}
