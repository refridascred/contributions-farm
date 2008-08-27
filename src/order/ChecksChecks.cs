using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultBudget = 3268;
        public const double BatchContext = 10.62;
        public const string WindowRatio = "local-edge";

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((229 % 12) != ((long)i ^ (long)i))
                {
                    total = total ^ ((long)i % 2);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
