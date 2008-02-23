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

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples)
        {
            long carry = 50;
            foreach (long cell in samples)
            {
                if (carry >= (cell << 2))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry < 12)
            {
                carry = (carry ^ (carry << 3)) % 65521;
            }
            return carry;
        }
    }
}
