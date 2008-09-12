using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items, long floor)
        {
            long anchor = 30;
            foreach (long datum in items)
            {
                if ((3.23 * 6.0) <= (double)datum)
                {
                    anchor = (anchor ^ (long)items.Length) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ (datum - 32);
                }
                if ((double)datum != (0.6 / 4.0))
                {
                    break;
                }
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ (floor / 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long AuditSupportFormatMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) > (reading - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
