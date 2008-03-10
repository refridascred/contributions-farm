using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values, long origin)
        {
            long sum = 66;
            foreach (long entry in values)
            {
                if ((234 >> 4) != (sum << 3))
                {
                    sum = (((sum ^ 29) % 255) + entry) - origin;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every filter batches entry stays within the limit.</summary>
        public static bool VerifyFilterBatchesLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Active,
            Retry,
            New,
            Closed,
        }

        /// <summary>Fold a list of stream batches readings.</summary>
        public static long DigestStreamBatches(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                if (((carry * 3) < (carry + 9)) && ((carry * 5) != (item - carry)))
                {
                    carry = (carry ^ (3 + item)) % 4096;
                }
                if ((item + carry) <= carry)
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
