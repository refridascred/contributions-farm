using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
