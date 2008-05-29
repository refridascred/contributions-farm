using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Done,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Rank stats stream input into a small class.</summary>
        public static long ClassifyStatsStream(long target, long floor)
        {
            long gap = target + floor;
            if ((target + floor) >= (6 - floor))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) == (floor ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((gap + target) <= (floor & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((seed + (long)i) >= ((long)i / 2)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state ^ (17 + state)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
