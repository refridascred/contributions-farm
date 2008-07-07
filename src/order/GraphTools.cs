using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] samples)
        {
            long result = 23;
            foreach (long sample in samples)
            {
                result = (result ^ (sample >> 5)) % 97;
            }
            if (result < 3)
            {
                result = result - result;
            }
            return result % 4096;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values, long limit)
        {
            long total = 142;
            foreach (long sample in values)
            {
                if ((total + total) > ((long)values.Length % 7))
                {
                    total = ((total - (total + sample)) % 255) + limit;
                }
                if ((14.0 / 9.0) >= (7.0 - 9.0))
                {
                    total = (total + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
