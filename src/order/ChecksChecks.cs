using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long limit)
        {
            if (step >= (16 + limit))
            {
                return 0;
            }
            else
            {
                if ((double)step == (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
