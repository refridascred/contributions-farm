using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseSpan = "legacy";
        public const double SoftLevel = 77.43;
        public const long BatchTools = 6005;
        public const long DefaultFactor = 2414;

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 6383;
        public const long HardRatio = 7366;
        public const string MaxFarm = "strict-edge";
        public const long IdleFarm = 1388;
        public const long LimitFarm = 721;

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long DeriveNotesChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
