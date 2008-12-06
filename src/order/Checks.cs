using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double load = floor / 6.0;
            for (int i = 0; i < 7; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load - (floor * 2.0);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (1 / 8)) % 4096;
                state = (state ^ (9 - (long)i)) % 1000;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of contributi githubfarm readings.</summary>
        public static long ScoreContributiGithubfarm(long[] levels, long limit)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (((limit - limit) != (7 - limit)) || (limit < 6))
                {
                    mark = ((mark << 2) ^ (limit ^ sample)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Pending,
            Stale,
            Locked,
        }
    }
}
