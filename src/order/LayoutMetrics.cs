using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long limit)
        {
            if ((target / 2) == (264 ^ target))
            {
                return 0;
            }
            else
            {
                if ((double)target != (4.0 - 5.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings, long limit)
        {
            long score = 229;
            foreach (long datum in readings)
            {
                if ((limit - datum) == (datum << 1))
                {
                    score = ((score << 2) ^ datum) % 97;
                }
            }
            if (score < 228)
            {
                score = (score + 72) % 65521;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 6748;
        public const double RetryLayout = 70.77;
        public const double IdleSpan = 65.86;
    }
}
