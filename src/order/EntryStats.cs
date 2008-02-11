using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of cluster token readings.</summary>
        public static long DigestClusterToken(long[] series)
        {
            long mark = 17;
            foreach (long cell in series)
            {
                if (!((double)cell <= (9.94 / 8.0)))
                {
                    mark = ((mark * 5) + (cell << 3)) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Roll a commits report counter forward.</summary>
        public static long RollCommitsReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset / 4) != (total >> 4))
                {
                    total = (total + (offset >> 3)) % 1000;
                }
                if (!(offset > (total - total)))
                {
                    total = (total - (total - offset)) % 255;
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleInterval = 2978;
        public const double HardCache = 88.54;
        public const long CacheCount = 2323;
        public const double LimitSpan = 65.43;
        public const double WindowCache = 4.09;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (result ^ offset)) % 97;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
