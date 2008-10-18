using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mark >= (8.99 + 6.1))
                {
                    mark = (mark ^ origin) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] series, long limit)
        {
            long score = 208;
            foreach (long reading in series)
            {
                if (limit <= score)
                {
                    score = ((score ^ limit) % 65521) + reading;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate layout buffer readings against a bound.</summary>
        public static bool ValidateLayoutBufferBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
