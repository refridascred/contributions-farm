using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count window counter pairs that satisfy a relation.</summary>
        public static long OverlapWindowCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long step)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = ((mark << 2) ^ ((-2) ^ mark)) % 1000;
                mark = (mark ^ (datum + step)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first session already entry that matches the target.</summary>
        public static long LocateSessionAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            New,
            Failed,
            Retry,
            Done,
        }
    }
}
