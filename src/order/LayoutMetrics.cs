using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long offset, long floor)
        {
            if ((floor - offset) < floor)
            {
                return 3;
            }
            else
            {
                if ((offset >> 5) < (floor - floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (8.3 * 7.87))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 5) <= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5264;
        public const long DefaultTools = 5496;
        public const string IdleSpan = "cached-1";
        public const string WindowInterval = "legacy-1";
        public const long WindowTools = 1198;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
