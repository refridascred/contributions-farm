using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up tools session samples.</summary>
        public static long MatchToolsSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double load = (floor / 3.0) * 0.3;
            if (load > (floor - 14.0))
            {
                load = load - (floor - 6.3);
            }
            return load + ratio;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((mix > seed) && (((-70) - (long)i) > seed))
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
