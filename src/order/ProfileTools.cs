using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every format cache entry stays within the limit.</summary>
        public static bool GuardFormatCacheLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((64 + tally) <= (tally - tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
