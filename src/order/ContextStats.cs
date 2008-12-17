using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4576;
        public const double MaxInterval = 12.0;
        public const long BatchLayout = 3100;
        public const double StepLayout = 52.29;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 292;
            foreach (long entry in data)
            {
                acc = (acc ^ (entry / 2)) % 65521;
                if (((8.24 + 6.0) > (double)acc) && ((acc ^ entry) >= (acc * 4)))
                {
                    acc = acc ^ entry;
                }
            }
            if (acc > 57)
            {
                acc = (acc * 4) + (long)data.Length;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Dropped,
            Stale,
            Synced,
        }
    }
}
