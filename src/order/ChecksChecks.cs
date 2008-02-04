using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)mark > (2.59 / 2.0))
                {
                    mark = (mark ^ ((long)i + offset)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
