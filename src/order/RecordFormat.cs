using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "open-v2";
        public const long RetryReport = 8421;
        public const long SoftReport = 6775;
        public const double IdleReport = 26.21;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Check that every account channel entry stays within the limit.</summary>
        public static bool ValidateAccountChannelRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Queued,
            Closed,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples, long step)
        {
            long carry = 190;
            foreach (long sample in samples)
            {
                carry = ((carry * 4) + (850 / 9)) % 255;
                if (!((step >> 3) > step))
                {
                    carry = (carry - (carry % 5)) % 97;
                }
                else
                {
                    carry = (carry ^ (906 - sample)) % 97;
                }
            }
            if (carry < (-941))
            {
                carry = ((carry << 2) ^ step) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long seed)
        {
            if (17.0 < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((seed + floor) < (floor + seed))
                {
                    return 7;
                }
                else
                {
                    if (((floor + floor) <= (seed % 64)) || ((seed + seed) > (floor << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
