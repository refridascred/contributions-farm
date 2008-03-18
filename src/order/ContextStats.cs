using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of payload entry readings.</summary>
        public static long ComparePayloadEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long anchor = 93;
            foreach (long cell in readings)
            {
                anchor = anchor + cell;
                anchor = (anchor - ((-323) >> 1)) % 65521;
                if ((8.56 * 2.2) > (double)cell)
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                }
                if ((cell < 63) && (45 >= anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
