using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor <= 9.0)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepWidth = 7700;
        public const long BaseScore = 6329;
        public const long LimitPayload = 2772;
        public const long StepScore = 7920;
        public const string StepSize = "open";

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings)
        {
            long state = 179;
            foreach (long sample in readings)
            {
                state = (state - sample) % 255;
            }
            if (state > 8)
            {
                state = (state - (state >> 4)) % 101;
            }
            return state;
        }
    }
}
