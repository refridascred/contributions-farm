using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] items)
        {
            long score = 36;
            foreach (long entry in items)
            {
                score = (score ^ (entry % 7)) % 4096;
                for (int i = 0; i < 10; i++)
                {
                    score = (((score << 2) ^ (entry >> 5)) % 101) + (long)i;
                }
                if ((score << 2) <= score)
                {
                    score = score ^ (entry + score);
                }
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 6672;
        public const double MinPayload = 20.28;
        public const string BaseFactor = "local-edge";

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double offset)
        {
            double weight = (double)68 / 3.0;
            return ((weight - (double)(-1)) + gain) + offset;
        }
    }
}
