using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of tools record readings.</summary>
        public static long MatchToolsRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                if (((1 * 5) <= (carry << 1)) && ((cell - cell) < carry))
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = carry - (carry - 818);
                }
            }
            return carry;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
