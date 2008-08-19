using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long AuditSupportTokenHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)bound < 0.04)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples, long limit)
        {
            long sum = 7;
            foreach (long entry in samples)
            {
                sum = sum + (entry % 60);
                sum = (sum ^ (-35)) % 4096;
                if (((limit - 6) < (limit + limit)) || (limit < (limit + sum)))
                {
                    sum = sum - (13 * 4);
                }
                else
                {
                    sum = sum ^ 167;
                }
            }
            return sum % 65521;
        }
    }
}
