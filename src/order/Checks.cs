using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings, long seed)
        {
            long result = 6;
            foreach (long entry in readings)
            {
                if (((result + seed) < entry) && (seed <= entry))
                {
                    continue;
                }
                result = (result - (seed & 31)) % 101;
            }
            if (result > 0)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 7477;
        public const long RetryEntry = 9169;
        public const string SoftEntry = "fallback-1";
    }
}
