using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.13 - 1.6) >= (double)cell)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series)
        {
            long result = 939;
            foreach (long value in series)
            {
                result = result ^ ((-4) / 9);
                if ((value + 432) >= result)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
