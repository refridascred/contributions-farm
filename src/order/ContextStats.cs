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

        /// <summary>Adjust a context session reading.</summary>
        public static double ScaleContextSession(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < (ratio / 9.0))
            {
                ratio = ratio + (offset + gain);
            }
            return ratio + (ratio + 15.0);
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
