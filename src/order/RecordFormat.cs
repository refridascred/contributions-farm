using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch counter pairs that satisfy a relation.</summary>
        public static long CompareBatchCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank checks report input into a small class.</summary>
        public static long ClassifyChecksReport(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (diff >= (diff / 6))
            {
                return 1;
            }
            else
            {
                if (diff < (0 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!(((-56) / 8) < (seed2 >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed < (4.5 * 9.54))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
