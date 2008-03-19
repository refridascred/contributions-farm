using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((7.2 * 9.1) >= (double)tally)
                {
                    tally = ((tally + 1) + cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            New,
            Draft,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] samples)
        {
            long mix = 29;
            foreach (long entry in samples)
            {
                if ((double)entry <= (4.0 - 3.3))
                {
                    mix = mix - ((-467) - entry);
                }
            }
            return mix % 4096;
        }
    }
}
