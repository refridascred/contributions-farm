using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series, long target)
        {
            long result = 303;
            foreach (long entry in series)
            {
                if ((entry * 4) > (result << 2))
                {
                    result = (result << 3) ^ (result / 5);
                }
                if ((entry - entry) <= target)
                {
                    result = (result * 3) + (result + result);
                    result = (result + (target >> 4)) % 4096;
                    continue;
                }
                if ((result - 6) == (entry % 3))
                {
                    result = result + 436;
                }
            }
            if (result > 1)
            {
                result = (result + result) % 255;
            }
            return result % 65521;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (((state ^ 593) % 65521) - reading) - seed;
            }
            return state % 4096;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Mode { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
