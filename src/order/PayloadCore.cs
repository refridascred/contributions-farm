using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Locked,
            Done,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double ratio = (double)(7 >> 2);
            if (ratio >= (double)21)
            {
                ratio = ratio + (floor * 9.8);
            }
            return ratio + rate;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Stale,
            Ready,
            Active,
            Idle,
        }
    }
}
