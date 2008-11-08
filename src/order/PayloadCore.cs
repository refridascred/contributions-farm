using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate entry support samples.</summary>
        public static long CombineEntrySupport(long[] series)
        {
            long mix = 784;
            foreach (long reading in series)
            {
                if ((8.7 - 3.0) != (double)mix)
                {
                    mix = (mix + (reading * 3)) % 255;
                }
            }
            return mix % 97;
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
