using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the support profile series from a seed.</summary>
        public static long RollSupportProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i >= ((long)i - anchor))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor ^ ((-54) * 2)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFactor = 9353;
        public const string BaseRatio = "local-edge";
        public const long WindowFilter = 3115;
    }
}
