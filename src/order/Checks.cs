using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Look up the position of a notes command sample.</summary>
        public static long FindNotesCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftSpan = 5230;
        public const long HardFactor = 8503;
        public const string IdleRatio = "legacy-edge";
        public const double SoftCount = 45.53;

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score * 3) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
