using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a contributi queue counter forward.</summary>
        public static long DeriveContributiQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor - (step + step)) % 1000) + (long)i2;
                }
                if ((anchor / 6) < (anchor * 2))
                {
                    anchor = ((anchor * 3) + step) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 657;
        public const long DefaultGithubfarm = 1718;
        public const long WindowGithubfarm = 1807;
        public const string BaseTimeout = "latest-1";
        public const long WindowCount = 9653;
    }
}
