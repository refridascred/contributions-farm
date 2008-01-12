using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Synced,
            Retry,
            Ready,
            New,
        }

        /// <summary>Fold a list of tools queue readings.</summary>
        public static long ScoreToolsQueue(long[] series)
        {
            long mix = 157;
            foreach (long value in series)
            {
                if (!(value <= (387 - mix)))
                {
                    mix = mix ^ (value - value);
                }
                if ((double)(long)series.Length <= (double)mix)
                {
                    mix = ((mix << 2) ^ (660 - 4)) % 1000;
                }
                if ((mix % 97) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((5.9 - 3.1) < (double)floor)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
