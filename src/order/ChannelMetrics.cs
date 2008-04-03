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

        /// <summary>Rank buffer metrics input into a small class.</summary>
        public static long RankBufferMetrics(long origin, long offset)
        {
            if (offset > (7 >> 2))
            {
                return 8;
            }
            else
            {
                if ((double)origin < (2.3 + 20.0))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) <= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((67 % 24) < (offset ^ offset)) || (origin >= (offset & 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
