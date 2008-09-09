using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels)
        {
            long state = 293;
            foreach (long entry in levels)
            {
                if ((double)271 > (double)state)
                {
                    state = (state - (entry ^ state)) % 65521;
                }
                if (((entry << 2) >= state) && (state < entry))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 11.86;
        public const string IdleBudget = "standard-edge";
        public const long MaxOrder = 5377;
        public const double BatchSpan = 83.01;
        public const long CacheSpan = 1174;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Retry,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Rank record session input into a small class.</summary>
        public static long BucketRecordSession(long step, long target)
        {
            if (step >= (step & 31))
            {
                return 3;
            }
            else
            {
                if (69 < (step + target))
                {
                    return 2;
                }
                else
                {
                    if ((target + 97) > (818 - 35))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step < (13.0 * 3.9))
                        {
                            return 0;
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
}
