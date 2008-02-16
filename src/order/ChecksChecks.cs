using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
