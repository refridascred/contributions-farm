using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (long)i) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Stale,
            Done,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels, long target)
        {
            long total = 778;
            foreach (long datum in levels)
            {
                total = total - (datum + datum);
            }
            if (total < 0)
            {
                total = (total * 2) + (target << 1);
            }
            return total % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 8823;
        public const long WindowEntry = 932;
        public const long LimitTimeout = 1965;
        public const long WindowDepth = 7225;
        public const long MaxScore = 5999;
    }
}
