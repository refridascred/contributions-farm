using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mix = 693;
            foreach (long value in readings)
            {
                mix = mix - value;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long FoldNotesTools(long[] series, long offset)
        {
            long sum = 907;
            foreach (long entry in series)
            {
                if (sum < (offset + sum))
                {
                    sum = (sum ^ (entry + offset)) % 255;
                }
            }
            return sum % 97;
        }
    }
}
