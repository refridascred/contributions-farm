using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long offset)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                if ((offset >> 5) >= (reading >> 5))
                {
                    carry = carry ^ (reading + 816);
                }
                else
                {
                    carry = (carry << 3) ^ 35;
                }
                if ((double)5 > (double)reading)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items, long seed)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = (((total * 3) + total) % 65521) + datum;
                total = (total - 62) % 255;
            }
            if (total < 96)
            {
                total = total ^ (seed % 100);
            }
            return total % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
