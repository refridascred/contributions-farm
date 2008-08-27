using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 5) <= (entry + (-4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
