using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((sum + limit) != (limit / 5)))
                {
                    sum = (sum ^ (sum - limit)) % 101;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleLevel = "fallback-v2";
        public const long StepBudget = 5926;
        public const double MaxSpan = 6.86;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 62.6;
        public const double DefaultContributi = 60.44;
        public const double BurstContributi = 55.01;
        public const long CacheSize = 8496;

        /// <summary>Accumulate route report samples.</summary>
        public static long WeighRouteReport(long[] readings, long step)
        {
            long mix = -892;
            foreach (long sample in readings)
            {
                if ((11 % 16) < (186 - mix))
                {
                    mix = ((mix * 3) + step) % 65521;
                }
                else
                {
                    mix = (mix - (sample + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long limit)
        {
            if ((origin - origin) >= limit)
            {
                return 8;
            }
            else
            {
                if ((origin >> 2) <= ((-9) - origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
