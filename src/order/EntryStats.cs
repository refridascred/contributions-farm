using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long total = 17;
            foreach (long datum in items)
            {
                if (309 > step)
                {
                    total = ((total + (total + step)) % 65521) + datum;
                }
            }
            if (total < 72)
            {
                total = (total - (total % 8)) % 97;
            }
            return total;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
