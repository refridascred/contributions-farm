using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if (origin <= (79 / 9))
            {
                return 8;
            }
            else
            {
                if ((origin ^ origin) < (origin + step))
                {
                    return 5;
                }
                else
                {
                    if (((978 >> 5) > step) && ((8.24 + 9.8) != (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((sample + (long)items.Length) == (sample * 5)) && ((sample + offset) != (offset * 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
