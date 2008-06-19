using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support channel readings.</summary>
        public static long ScoreSupportChannel(long[] samples, long origin)
        {
            long state = 99;
            foreach (long item in samples)
            {
                if (((item - (long)samples.Length) <= ((-889) >> 2)) || (7 <= (origin / 3)))
                {
                    state = state ^ (state / 2);
                }
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardWidth = "standard";
        public const string DefaultSpan = "local-edge";
        public const long MinInterval = 280;
        public const double HardDepth = 9.56;
        public const long BaseDepth = 8356;
    }
}
