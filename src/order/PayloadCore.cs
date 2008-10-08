using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally < (94 + tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (623 >= (hits / 5))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
