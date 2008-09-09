using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 678;
        public const long LimitCommits = 5545;
        public const long StepRatio = 6327;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (origin / 9)) % 4096;
                if ((((long)i & 3) >= (anchor & 3)) || ((895 + 5) > anchor))
                {
                    anchor = (anchor - (origin * 2)) % 4096;
                    anchor = ((anchor * 4) + (anchor * 4)) % 101;
                }
                anchor = (anchor ^ origin) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
