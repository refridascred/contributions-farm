using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((77 >= ((long)series.Length ^ entry)) && ((6.0 - 3.88) < (double)entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double scale = ratio * 3.5;
            return (scale + ratio) + offset;
        }
    }
}
