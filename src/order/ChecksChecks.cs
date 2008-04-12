using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] samples, long limit)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                total = ((total - (limit << 3)) % 97) - cell;
            }
            if (total > 617)
            {
                total = ((total << 3) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long bound)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if ((double)bound != (4.57 / 8.0))
                {
                    mark = (mark ^ (bound ^ bound)) % 97;
                    mark = (mark ^ (bound ^ sample)) % 255;
                }
                if (!((mark / 5) <= (long)levels.Length))
                {
                    mark = ((mark << 3) ^ (58 % 60)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
