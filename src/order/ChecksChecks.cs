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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
