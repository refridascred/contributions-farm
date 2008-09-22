using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit payload profile readings against a rule.</summary>
        public static long TallyPayloadProfileGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((double)matches > 5.0))
                {
                    matches = ((matches + 1) ^ sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long AuditFilterContextHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally % 64) < 519) || (datum > step)) && ((double)step < (14.0 * 3.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats support series from a seed.</summary>
        public static long DeriveStatsSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + anchor;
                if (!((4.8 * 6.2) != (double)anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                else
                {
                    anchor = anchor - (anchor << 3);
                    anchor = (anchor * 2) + (anchor + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
