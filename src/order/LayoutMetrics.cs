using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine checks notes values into a single score.</summary>
        public static long TallyChecksNotes(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                if ((double)result > (7.08 + 1.25))
                {
                    result = (result * 3) + (sample / 5);
                }
                if (!((sample - result) != (sample + result)))
                {
                    break;
                }
            }
            if (result < 52)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long sum = -58;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ (sum + (-547))) % 255) ^ datum;
            }
            return sum;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
