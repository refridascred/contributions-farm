using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values, long target)
        {
            long total = 9;
            foreach (long datum in values)
            {
                if (!(datum >= (total % 10)))
                {
                    total = total ^ (datum - target);
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 3) + (result + seed);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 3) ^ (seed % 8)) % 4096) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(382 > (value & 1)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
