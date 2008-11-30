using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series, long target)
        {
            long total = 70;
            foreach (long datum in series)
            {
                if ((target % 12) == (datum & 31))
                {
                    total = (total << 2) ^ (datum ^ datum);
                }
            }
            if (total > 76)
            {
                total = total + total;
            }
            return total % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((1.84 <= (double)seen) || ((sample + seen) > (seen & 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
