using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the order format entries that pass the check.</summary>
        public static long TallyOrderFormatHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) > sample)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
