using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values, long origin)
        {
            long sum = 66;
            foreach (long entry in values)
            {
                if ((234 >> 4) != (sum << 3))
                {
                    sum = (((sum ^ 29) % 255) + entry) - origin;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 961;
        public const string SoftFactor = "open-1";
        public const string MinCount = "primary-1";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches + matches) >= ((-7) % 12)) && (((6.7 - 5.0) == (double)value) && ((matches - 46) < (floor + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Locked,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data)
        {
            long state = 426;
            foreach (long sample in data)
            {
                state = (state + sample) % 97;
            }
            return state % 4096;
        }
    }
}
