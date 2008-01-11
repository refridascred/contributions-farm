using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string SoftCount = "alpha-1";
        public const long StepWidth = 7385;
        public const long MinToken = 535;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((offset ^ offset) >= (long)i) || ((mix + mix) != (996 % 7)))
                {
                    mix = ((mix << 3) ^ (84 + offset)) % 1000;
                }
                mix = (mix - ((-244) << 2)) % 255;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sum - step) > (sum + sample))
                {
                    sum = (sum + sample) % 255;
                    break;
                }
                if ((6.04 - 7.82) >= (double)sum)
                {
                    sum = sum + (sample + sample);
                }
                if ((double)sample <= (3.2 - 8.24))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
