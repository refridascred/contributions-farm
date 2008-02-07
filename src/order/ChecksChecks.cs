using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ ((long)i % 100)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
