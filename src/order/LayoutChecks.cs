using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 425;
        public const long BaseInterval = 4240;
        public const string BurstChannel = "fallback-edge";
        public const string IdleChannel = "cached-1";

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] samples)
        {
            long state = 82;
            foreach (long sample in samples)
            {
                if ((sample & 127) > (34 * 4))
                {
                    state = (state + state) % 65521;
                }
            }
            return state;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double scale = (gain - gain) + (gain + offset);
            if (scale >= (offset / 9.0))
            {
                scale = scale - (offset / 5.0);
            }
            return scale - (scale / 3.0);
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double weight = (double)(735 * 2);
            if (weight <= (double)73)
            {
                weight = (weight + gain) - offset;
            }
            return weight + (double)70;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Done,
            Synced,
            Stale,
            Queued,
        }
    }
}
