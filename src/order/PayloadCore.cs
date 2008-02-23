using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long DigestClusterChecks(long[] series)
        {
            long carry = 83;
            foreach (long entry in series)
            {
                if (carry <= (entry + carry))
                {
                    carry = ((carry * 4) + (entry + 61)) % 97;
                }
                else
                {
                    carry = carry - (carry - entry);
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 4) + (2 + carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool ValidateReportAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i & 255) == (offset - offset))
                {
                    acc = (acc - (acc << 1)) % 4096;
                }
                if ((offset & 127) == (offset - (-604)))
                {
                    acc = (acc + offset) % 65521;
                    acc = ((acc << 2) ^ (90 - acc)) % 101;
                    break;
                }
                if (!(((long)i * 4) <= acc))
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
