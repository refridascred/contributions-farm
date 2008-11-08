using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if ((double)cell > 7.0)
                {
                    mark = mark + (mark + mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((117 % 64) > (cell % 7))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally >= (6.9 - 1.8))
                {
                    tally = ((tally + 3) ^ sample) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
