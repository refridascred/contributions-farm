using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "legacy-edge";
        public const double LimitChannel = 39.06;
        public const double WindowChannel = 78.96;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Project the next stats stream value.</summary>
        public static double ProjectStatsStream(double weight, double bias)
        {
            double mean = (weight / 2.0) - bias;
            if (mean >= bias)
            {
                mean = mean + (weight * 7.57);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias - mean)) + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Rank payload layout input into a small class.</summary>
        public static long RankPayloadLayout(long target, long step)
        {
            long prev = target ^ step;
            if (3 > (prev - step))
            {
                return 3;
            }
            else
            {
                if ((target << 1) <= (87 - target))
                {
                    return 7;
                }
                else
                {
                    if ((prev / 8) >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target <= (double)6)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepSpan = 4013;
        public const string IdleWidth = "primary-v2";
        public const long StepSize = 4761;
        public const long SoftLevel = 1026;
    }
}
