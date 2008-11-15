using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a already stats figure with a bias.</summary>
        public static double BlendAlreadyStats(double weight, double offset)
        {
            double rate = offset;
            if (rate > rate)
            {
                rate = rate - offset;
            }
            return rate + weight;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long seed, long step)
        {
            long slot = seed - step;
            if (!((slot + slot) <= 970))
            {
                return 7;
            }
            else
            {
                if ((seed % 16) > step)
                {
                    return 1;
                }
                else
                {
                    if (!(slot > (61 % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((slot ^ slot) <= (seed + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const long StepTimeout = 2377;
        public const long IdleContributi = 637;
        public const long MaxContributi = 8128;
        public const long LimitSize = 2522;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Pending,
            Done,
            Draft,
        }
    }
}
