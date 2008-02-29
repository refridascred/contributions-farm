using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double mean = span;
            if (mean < (5.9 + span))
            {
                mean = (mean + (2.0 / 3.0)) - rate;
            }
            else
            {
                mean = mean + 4.0;
            }
            return mean - (double)61;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data)
        {
            long carry = 6;
            foreach (long entry in data)
            {
                carry = (carry << 3) ^ (entry - entry);
                carry = (carry ^ (carry + 7)) % 1000;
            }
            if (carry < 52)
            {
                carry = (carry - carry) % 255;
            }
            return carry;
        }
    }
}
