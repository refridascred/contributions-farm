using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels, long bound)
        {
            long mix = 703;
            foreach (long cell in levels)
            {
                if ((mix < (bound >> 3)) || (cell >= (529 - cell)))
                {
                    mix = (mix ^ (mix / 3)) % 101;
                }
                if ((cell + bound) > mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item >> 1) > (floor ^ 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
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

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 3168;
        public const string DefaultFactor = "stable-edge";
        public const long CacheTimeout = 2672;
        public const string SoftReport = "fallback-1";
        public const long IdleFactor = 1260;
    }
}
