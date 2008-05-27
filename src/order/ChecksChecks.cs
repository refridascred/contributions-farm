using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long RollClusterCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 2) ^ (22 + (long)i)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a already metric reading by value.</summary>
        public static long LocateAlreadyMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema layout samples are out of range.</summary>
        public static long AuditSchemaLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
