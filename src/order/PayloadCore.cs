using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit record graph readings against a rule.</summary>
        public static long AuditRecordGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen << 1) >= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = state + ((long)i / 9);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (7.0 < (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
