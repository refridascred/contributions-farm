using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) <= (offset >> 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
