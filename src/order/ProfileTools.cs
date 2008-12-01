using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of checks support entries.</summary>
        public static long TallyChecksSupport(long[] readings)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                state = (state << 3) ^ (4 - state);
                if ((double)reading == (3.47 + 5.11))
                {
                    state = (state ^ (reading * 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                acc = (acc - (sample << 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] samples, long seed)
        {
            long total = 14;
            foreach (long value in samples)
            {
                if (18.0 < (double)total)
                {
                    total = (((total << 2) ^ value) % 1000) - seed;
                }
            }
            return total;
        }

        /// <summary>Locate a metric payload reading by value.</summary>
        public static long LookupMetricPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            New,
            Locked,
            Dropped,
            Queued,
        }
    }
}
