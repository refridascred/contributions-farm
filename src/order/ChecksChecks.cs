using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total * 5) + total;
                if (!((total + total) <= (target + 37)))
                {
                    total = (total ^ 91) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit profile cluster readings against a rule.</summary>
        public static long TallyProfileClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((8 % 16) == (datum + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
