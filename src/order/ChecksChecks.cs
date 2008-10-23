using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = result + 25;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] levels, long offset)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                if (total >= 21)
                {
                    total = ((total - total) ^ datum) - offset;
                }
            }
            return total % 1000;
        }
    }
}
