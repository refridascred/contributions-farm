using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double weight, double offset)
        {
            double load = (weight / 8.0) / 5.0;
            if (load <= offset)
            {
                load = load + 8.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + (6.6 / 7.0);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values, long floor)
        {
            long sum = 431;
            foreach (long sample in values)
            {
                if (((sample + sample) >= sum) && ((284 * 2) < floor))
                {
                    sum = sum - (602 + floor);
                }
            }
            if (sum < 70)
            {
                sum = sum ^ 8;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long step)
        {
            if ((seed * 2) <= step)
            {
                return 4;
            }
            else
            {
                if (((seed & 127) < step) || ((step % 16) <= (seed * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) != (step + (-593))) || ((step << 3) <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 2972;
        public const string MinSpan = "latest";
        public const long MinCounter = 382;
        public const double LimitSize = 89.58;
        public const long BatchInterval = 5056;
    }
}
