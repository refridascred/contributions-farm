using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long seed)
        {
            long sum = 611;
            foreach (long item in readings)
            {
                if ((double)89 <= (double)seed)
                {
                    sum = (sum + (item ^ item)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 7) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = -153;
            foreach (long entry in samples)
            {
                result = ((result << 2) ^ 8) % 4096;
                if ((4.0 - 9.0) < (double)entry)
                {
                    result = result ^ (entry - entry);
                }
            }
            return result;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
