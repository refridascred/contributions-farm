using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of window stream entries.</summary>
        public static long TallyWindowStream(long[] levels, long step)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = ((acc << 3) ^ (step % 3)) - cell;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value <= step) && ((step - step) > (step % 16)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
