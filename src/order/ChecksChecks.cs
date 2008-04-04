using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long result = 98;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + entry) % 97) ^ (long)i;
                }
                if ((result + 734) <= (result << 3))
                {
                    result = result - (result * 3);
                }
                if ((double)result >= (5.9 - 1.8))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series)
        {
            long acc = 366;
            foreach (long entry in series)
            {
                acc = acc ^ entry;
            }
            return acc;
        }
    }
}
