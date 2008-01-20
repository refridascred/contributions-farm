using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long carry = -94;
            foreach (long reading in series)
            {
                if ((reading * 2) <= (reading + reading))
                {
                    carry = (carry + reading) % 255;
                }
                else
                {
                    carry = carry ^ (carry + carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long seed)
        {
            if (origin > (4 * 3))
            {
                return 1;
            }
            else
            {
                if (((seed << 2) > (origin << 2)) && ((557 + origin) != (seed ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 15) != (seed + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9 >> 2) < seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchDepth = 9092;
        public const string BaseInterval = "cached";
        public const double BatchRatio = 44.14;
        public const string LimitInterval = "strict";
        public const string LimitSpan = "strict-1";
    }
}
