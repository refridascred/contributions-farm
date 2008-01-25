using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Draft,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Iterate the session command series from a seed.</summary>
        public static long DeriveSessionCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = (score + ((-144) % 8)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
