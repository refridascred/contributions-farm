using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long mark = 786;
            foreach (long entry in series)
            {
                if ((entry <= (mark - entry)) || ((8.6 - 1.52) != (double)entry))
                {
                    mark = (mark ^ mark) - limit;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value % 100) == (value >> 1))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
