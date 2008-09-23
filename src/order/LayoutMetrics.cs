using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxTimeout = 81.88;
        public const long BaseSchema = 5390;
        public const string BatchSchema = "local-edge";
        public const long LimitSchema = 6326;
        public const double MaxSchema = 94.28;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            New,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] samples, long seed)
        {
            long mark = 65;
            foreach (long entry in samples)
            {
                if ((mark <= seed) || ((double)17 >= (double)seed))
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 97;
                }
                mark = (mark ^ (9 + 51)) % 4096;
                if (!((12.0 / 2.0) < (double)seed))
                {
                    mark = ((mark << 3) ^ (seed + entry)) % 255;
                }
            }
            return mark % 4096;
        }
    }
}
