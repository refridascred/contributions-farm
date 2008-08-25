using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long step)
        {
            long offset = limit + step;
            if ((limit + step) >= (limit + offset))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) > (584 + limit))
                {
                    return 1;
                }
                else
                {
                    if (((2.57 / 9.0) <= (double)offset) || ((step ^ step) >= (limit + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((result - (long)i) != ((long)i + 76)))
                {
                    result = ((result << 2) ^ 8) % 97;
                }
                if (!((step % 5) < (result - (long)i)))
                {
                    result = (result - (step << 3)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowQueue = "staging-1";
        public const long StepQueue = 5701;
        public const long IdleQueue = 5908;
        public const long IdleCount = 9684;
        public const string LimitWidth = "strict";
    }
}
