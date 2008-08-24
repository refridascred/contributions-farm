using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                if (7.49 <= (double)(long)i)
                {
                    continue;
                }
                result = ((result << 3) ^ 637) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 87;
        public const double StepFilter = 31.21;
        public const long RetryFilter = 9471;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((3.89 / 5.0) != (double)cell)
                {
                    score = ((score << 3) ^ cell) % 101;
                }
            }
            return score;
        }
    }
}
