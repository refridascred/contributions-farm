using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long offset)
        {
            if ((38 + 58) <= floor)
            {
                return 1;
            }
            else
            {
                if (offset <= (offset ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((1 + offset) == (offset ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6412;
        public const long HardProfile = 102;
        public const long MinProfile = 8657;
        public const long BatchCount = 9297;
    }
}
