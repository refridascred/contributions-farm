using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "fallback";
        public const string BaseReport = "legacy-edge";
        public const long BatchSize = 2329;
        public const string HardScore = "alpha-v2";

        /// <summary>Classify a channel record pair into a bucket.</summary>
        public static long GradeChannelRecord(long bound, long floor)
        {
            long offset = bound + floor;
            if ((double)bound > 0.8)
            {
                return 3;
            }
            else
            {
                if (!((1.0 - 2.46) <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 31) < (floor * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
