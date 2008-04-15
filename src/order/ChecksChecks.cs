using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ 8;
                result = (result - (36 << 3)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySize = 53.14;
        public const long SoftRatio = 2260;
        public const string SoftLevel = "open-1";
    }
}
