using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total << 2) ^ (total % 97)) ^ (long)i2;
                }
                if (!((origin << 3) != ((long)i + 30)))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
