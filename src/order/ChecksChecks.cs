using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long TallyProfileFarm(long[] samples, long bound)
        {
            long total = 51;
            foreach (long entry in samples)
            {
                total = total - (bound + bound);
                total = (total + ((long)samples.Length * 4)) % 101;
                if (!(((-280) - (-9)) >= (entry / 8)))
                {
                    total = (total ^ (bound + entry)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((hits >> 1) == (reading ^ reading)) && ((reading - reading) >= (reading << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
