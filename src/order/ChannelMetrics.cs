using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 6258;
        public const string MaxTimeout = "legacy-edge";
        public const double CacheBatch = 58.2;
        public const long DefaultBatch = 1996;

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = ((result + (result + (-166))) % 4096) + datum;
            }
            if (result > 2)
            {
                result = ((result << 3) ^ (5 >> 2)) % 1000;
            }
            return result;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
