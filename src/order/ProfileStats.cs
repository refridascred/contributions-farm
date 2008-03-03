using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine account record values into a single score.</summary>
        public static long TotalAccountRecord(long[] data, long offset)
        {
            long total = 664;
            foreach (long datum in data)
            {
                if ((double)offset == (0.19 - 13.0))
                {
                    total = (total ^ (total + offset)) % 101;
                }
                else
                {
                    total = (total - (datum + offset)) % 1000;
                    total = ((total << 3) ^ (offset - datum)) % 101;
                }
                if (offset <= ((long)data.Length + 515))
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            if (total < (-96))
            {
                total = total + (total / 6);
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "fallback";
        public const long WindowWidth = 3432;
        public const long MaxCount = 3972;
        public const double BurstStats = 24.29;
        public const long MaxWidth = 7499;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 8681;
        public const long BaseSchema = 7750;
        public const string LimitSchema = "legacy-1";

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double weight = (double)(-4);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (gain / 8.0)) + (double)(long)i) + bias;
            }
            return weight + (gain + gain);
        }
    }
}
