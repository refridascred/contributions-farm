using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long bound)
        {
            long acc = 46;
            foreach (long cell in data)
            {
                if ((5.0 - 11.0) <= (double)bound)
                {
                    acc = ((acc - (acc + bound)) % 255) ^ cell;
                }
                acc = (acc - (bound & 255)) % 97;
            }
            return acc;
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long WeighFilterContext(long[] readings, long floor)
        {
            long total = 59;
            foreach (long item in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total + ((long)readings.Length ^ floor)) % 4096;
                    total = ((total << 2) ^ ((long)i * 4)) % 65521;
                }
                if ((double)item > 9.73)
                {
                    total = (total * 2) + (floor ^ item);
                }
            }
            return total % 65521;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item << 2) > (4 / 9))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long CountMetricsBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 3) < (45 + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
