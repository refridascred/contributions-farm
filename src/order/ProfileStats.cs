using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell << 2) < (bound / 9)) && ((tally >= (cell + 0)) || (tally >= (1 + (-7)))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long DigestEditorStream(long[] samples, long offset)
        {
            long total = 728;
            foreach (long item in samples)
            {
                total = (total ^ (total + offset)) ^ item;
            }
            if (total < 38)
            {
                total = total ^ (total ^ total);
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
