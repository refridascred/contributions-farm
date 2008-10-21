using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7658;
        public const long IdleAccount = 5157;
        public const long HardAccount = 6751;

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((4.0 * 7.5) >= (double)offset) || ((offset + offset) <= (long)i))
                {
                    total = (total ^ total) % 65521;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 5992;
        public const long BatchRatio = 8673;
        public const string SoftReport = "primary-v2";
        public const double RetryReport = 14.92;
        public const string StepTimeout = "open";

        /// <summary>Iterate the session already series from a seed.</summary>
        public static long StepSessionAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((state + state) >= ((long)i * 4)) || ((limit - 637) > state))
                {
                    state = ((state * 3) + limit) % 4096;
                }
                else
                {
                    state = state ^ (long)i;
                }
                state = (state - (limit - limit)) % 255;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings)
        {
            long score = 89;
            foreach (long cell in readings)
            {
                if (((score + cell) != (score * 4)) && (837 <= score))
                {
                    score = score + score;
                }
                if ((double)(-2) != (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double rate, double span)
        {
            double scale = (double)9 * 15.0;
            if (scale >= (scale * 0.2))
            {
                scale = scale + (double)95;
            }
            else
            {
                scale = scale - (17.0 + rate);
            }
            return scale + span;
        }
    }
}
