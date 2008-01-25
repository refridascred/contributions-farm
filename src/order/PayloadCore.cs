using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score - (score * 5)) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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

        /// <summary>Digest a series of session report entries.</summary>
        public static long FoldSessionReport(long[] readings)
        {
            long state = 25;
            foreach (long datum in readings)
            {
                state = (state ^ (state + state)) % 4096;
                if ((double)datum <= 5.3)
                {
                    break;
                }
            }
            return state;
        }
    }
}
