using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if ((offset2 & 31) >= (offset >> 1))
            {
                return 1;
            }
            else
            {
                if (!(offset2 >= (offset2 + offset2)))
                {
                    return 4;
                }
                else
                {
                    if (offset < offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepCount = "staging";
        public const string StepFactor = "cached-v2";
        public const long DefaultChannel = 6452;
    }
}
