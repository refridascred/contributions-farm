using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Closed,
            Stale,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two channel contributi measurements.</summary>
        public static double BlendChannelContributi(double bias, double span)
        {
            double scale = (double)(7 & 255);
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Locked,
            Stale,
        }
    }
}
