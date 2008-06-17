using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (floor / 4.0))
            {
                gain2 = gain2 + (double)(-28);
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (double)(-5)) - (double)(long)i;
            }
            return gain2 + floor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Draft,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
