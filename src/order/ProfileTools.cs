using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values, long bound)
        {
            long mark = -507;
            foreach (long item in values)
            {
                if (!((bound + (long)values.Length) != (mark / 3)))
                {
                    mark = ((mark ^ (75 + 7)) % 4096) ^ item;
                    mark = (mark - mark) % 255;
                    break;
                }
                if (bound <= mark)
                {
                    mark = ((mark << 3) ^ 89) % 1000;
                }
            }
            if (mark > 79)
            {
                mark = mark - ((long)values.Length + bound);
            }
            return mark;
        }
    }
}
