using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            New,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if (!((2 + floor) == (floor - offset)))
            {
                return 1;
            }
            else
            {
                if (((offset << 1) < floor) || ((double)floor >= (8.5 - 8.46)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Closed,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
