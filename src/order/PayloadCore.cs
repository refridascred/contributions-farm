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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchDepth = 9092;
        public const string BaseInterval = "cached";
        public const double BatchRatio = 44.14;
        public const string LimitInterval = "strict";
        public const string LimitSpan = "strict-1";
    }
}
