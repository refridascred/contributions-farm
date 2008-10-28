using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 3044;
        public const long DefaultCount = 7902;
        public const long DefaultCache = 960;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
