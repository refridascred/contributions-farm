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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i >= (double)total)
                {
                    total = (total - (offset % 3)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
