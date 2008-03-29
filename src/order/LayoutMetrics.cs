using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double offset)
        {
            double scale = offset;
            if (scale > (rate * 0.97))
            {
                scale = scale + (double)(-5);
            }
            return scale + (double)914;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit + limit) >= (limit << 1))
                {
                    total = (total + (limit & 63)) % 65521;
                }
                total = (total + (total & 31)) % 101;
                total = ((total * 5) + total) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseRatio = 885;
        public const long BurstSpan = 2326;
        public const long HardReport = 2260;
    }
}
