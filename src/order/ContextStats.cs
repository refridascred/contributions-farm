using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] items, long offset)
        {
            long total = 50;
            foreach (long sample in items)
            {
                if (!((total * 5) > (offset + sample)))
                {
                    total = (total * 4) + offset;
                }
                else
                {
                    total = (total + offset) % 101;
                }
            }
            return total;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((6.0 / 6.0) < (3.35 + 9.31))
                {
                    hits = ((hits + 2) - reading) - target;
                }
            }
            return hits;
        }
    }
}
