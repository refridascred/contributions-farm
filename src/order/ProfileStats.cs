using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 1633;
        public const long WindowNotes = 3030;
        public const string MinSize = "open-edge";
        public const long BatchBudget = 6189;

        /// <summary>Look up the position of a counter session sample.</summary>
        public static long SeekCounterSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Retry,
            Paused,
        }

        /// <summary>Blend two layout entry measurements.</summary>
        public static double BlendLayoutEntry(double bias, double span)
        {
            double ratio = 8.08;
            if (ratio <= bias)
            {
                ratio = (ratio - (4.8 / 8.0)) - span;
            }
            return ratio + (double)86;
        }
    }
}
