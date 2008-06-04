using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchDepth = "stable-1";
        public const long CacheGraph = 4170;
        public const double BaseSpan = 65.54;
        public const double MinScore = 54.24;
        public const string BatchGraph = "fallback-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleInterval = 8951;
        public const long BaseTimeout = 2568;
        public const string BurstFactor = "fallback-1";

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long floor)
        {
            long anchor = 97;
            foreach (long cell in values)
            {
                anchor = ((((anchor * 5) + (anchor << 1)) % 97) ^ cell) - floor;
            }
            return anchor;
        }
    }
}
