using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultSize = "legacy-1";
        public const string DefaultChannel = "primary";
        public const long BaseChannel = 5892;

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
