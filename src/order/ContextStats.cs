using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen / 9) > (seen ^ value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit token window readings against a rule.</summary>
        public static long CountTokenWindowMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((floor * 3) <= (seen * 4))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile cluster sample.</summary>
        public static long LocateProfileClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
