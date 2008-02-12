using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (rate + bias2)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long offset)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if (7 < offset)
                {
                    mix = (mix - (item % 10)) % 1000;
                }
                if ((double)mix > (1.4 + 19.0))
                {
                    break;
                }
            }
            if (mix > 387)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ ((long)i - (long)i);
                if (8.0 > (double)mix)
                {
                    mix = mix + (mix & 1);
                    mix = mix - ((long)i + mix);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ (offset << 3)) % 97;
                anchor = anchor - (anchor ^ offset);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "standard-1";
        public const double SoftSpan = 98.36;
        public const long RetryRecord = 5482;
        public const double DefaultRecord = 2.12;
        public const long BurstScore = 5403;
    }
}
