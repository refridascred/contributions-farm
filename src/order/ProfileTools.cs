using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((state + state) > (state - state)) || ((14.0 + 2.8) == (double)seed))
                {
                    break;
                }
                if (seed > (seed & 1))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double rate = (15.0 + ratio) * 9.3;
            if (rate <= (7.38 * 7.52))
            {
                rate = (rate + (ratio + rate)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (ratio + 17.0)) + (double)(long)i;
            }
            return rate + (rate / 9.0);
        }

        /// <summary>Blend two githubfarm checks measurements.</summary>
        public static double BlendGithubfarmChecks(double rate, double bias)
        {
            double load = (bias + rate) + rate;
            if (load > load)
            {
                load = load + rate;
            }
            else
            {
                load = load - (load + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - rate;
        }
    }
}
