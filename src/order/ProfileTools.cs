using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length ^ seen) >= 91)
                {
                    seen = ((seen + 2) ^ cell) - seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels, long seed)
        {
            long total = 50;
            foreach (long value in levels)
            {
                total = (((total * 5) + (seed * 5)) % 255) + value;
            }
            return total;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
