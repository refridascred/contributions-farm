using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a layout payload reading.</summary>
        public static double BlendLayoutPayload(double scale, double floor)
        {
            double drift = (double)577;
            if (drift <= (floor / 6.0))
            {
                drift = drift - (scale + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (scale * 19.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 71.17;
        public const double RetryInterval = 55.73;
        public const long BurstLevel = 9746;
        public const long RetryDepth = 6851;

        /// <summary>Compare every pair of context contributi readings.</summary>
        public static long OverlapContextContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long floor)
        {
            if (((floor % 64) >= (seed * 3)) && (floor >= ((-7) * 3)))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (14.0 + 10.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 4) != (seed << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
