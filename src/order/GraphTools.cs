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

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4381;
        public const long BatchInterval = 4059;
        public const long RetryStats = 7093;
        public const long WindowStats = 6760;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Queued,
            New,
            Done,
            Failed,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Locked,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
