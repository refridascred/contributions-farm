using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long origin)
        {
            long mark = -4;
            foreach (long entry in readings)
            {
                mark = (mark ^ mark) % 4096;
                mark = mark + entry;
                if ((origin << 3) <= (779 & 31))
                {
                    mark = mark + ((long)readings.Length + entry);
                }
                else
                {
                    mark = ((mark * 2) + (origin + origin)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((step % 7) != (origin >> 2))
            {
                return 7;
            }
            else
            {
                if ((origin * 5) <= (step & 7))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
