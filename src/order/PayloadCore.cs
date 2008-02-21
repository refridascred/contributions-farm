using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of notes session readings.</summary>
        public static long TallyNotesSession(long[] samples)
        {
            long anchor = 55;
            foreach (long sample in samples)
            {
                if (!((3 << 1) >= anchor))
                {
                    anchor = (anchor - (anchor + (long)samples.Length)) + sample;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally / 2) >= (113 << 1)) || ((entry << 2) != (entry + tally)))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }
    }
}
