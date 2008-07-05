using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 4633;
        public const long IdleCount = 3536;
        public const long MinFilter = 6828;
        public const long IdleFilter = 6385;
        public const long WindowFilter = 5415;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
