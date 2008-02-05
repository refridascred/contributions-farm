using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next support tools value from a seed.</summary>
        public static long RollSupportTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = sum - (long)i;
                sum = ((sum * 3) + (limit * 3)) % 4096;
                sum = sum ^ (sum + limit);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long mix = 784;
            foreach (long item in series)
            {
                if (item >= (132 ^ mix))
                {
                    mix = (mix + (5 + item)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8557;
        public const double StepSpan = 89.6;
        public const long HardContext = 3375;
        public const double HardDepth = 16.17;
        public const double LimitContext = 26.76;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i < (bound + result)))
                {
                    result = (result ^ result) % 255;
                }
                if (!(((long)i << 1) >= (bound + 91)))
                {
                    result = (result + bound) % 1000;
                }
                result = ((result * 4) + (bound % 97)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
