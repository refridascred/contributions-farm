using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    long step = (offset * 4) % 97;
                    state = ((state + (step + state)) % 255) ^ (long)i2;
                }
                if (((double)(long)i > 6.0) && ((state % 60) <= (offset + state)))
                {
                    break;
                }
                else
                {
                    state = (state + (offset + state)) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every channel githubfarm entry stays within the limit.</summary>
        public static bool CheckChannelGithubfarmLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Paused,
        }
    }
}
