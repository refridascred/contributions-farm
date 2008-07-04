using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a session context value against two limits.</summary>
        public static long ClassifySessionContext(long floor, long step)
        {
            if ((step >> 3) >= step)
            {
                return 4;
            }
            else
            {
                if ((step << 2) < step)
                {
                    return 8;
                }
                else
                {
                    if (((floor * 5) > (floor + 111)) && ((step + floor) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (total < floor)
                {
                    total = (total + total) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long score = 296;
            foreach (long value in items)
            {
                if (!(8.0 < (double)score))
                {
                    score = (score - (39 << 2)) - value;
                }
            }
            if (score > 792)
            {
                score = (score + floor) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
