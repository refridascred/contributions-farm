using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((seed >> 2) == (101 + (long)i)) || ((-48) <= (seed / 7)))
                {
                    result = (result * 3) + seed;
                }
                result = (result + result) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
