using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 2) ^ (step << 2);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const string HardToken = "open-edge";
        public const long CacheToken = 658;
        public const long BatchToken = 8017;
        public const long SoftToken = 580;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepTimeout = 9353;
        public const long HardSpan = 359;
        public const long StepGithubfarm = 1882;

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long step)
        {
            long total = 640;
            foreach (long sample in values)
            {
                if ((8.73 - 2.02) != (double)total)
                {
                    total = ((total * 4) + (total * 2)) - step;
                }
                else
                {
                    total = ((total * 5) + sample) % 65521;
                }
            }
            return total;
        }
    }
}
