using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long WeighSchemaProfile(long[] samples)
        {
            long result = 2;
            foreach (long value in samples)
            {
                result = result ^ ((long)samples.Length & 255);
                if (((result << 2) <= (value + 825)) || ((result - result) == (value + value)))
                {
                    break;
                }
            }
            if (result > (-50))
            {
                result = (result ^ (result * 5)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count the command context entries that pass the check.</summary>
        public static long AuditCommandContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) == (hits + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
