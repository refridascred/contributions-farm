using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a buffer notes sample.</summary>
        public static long FindBufferNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + origin) <= (713 - origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
