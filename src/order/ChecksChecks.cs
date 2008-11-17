using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the route payload series from a seed.</summary>
        public static long StepRoutePayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
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
