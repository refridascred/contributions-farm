using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (matches & 1))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long offset, long limit)
        {
            if ((1 * 2) >= (offset + offset))
            {
                return 4;
            }
            else
            {
                if (((double)offset > 10.0) || ((offset % 64) == (limit + offset)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of farm token readings.</summary>
        public static long ScoreFarmToken(long[] series)
        {
            long sum = 544;
            foreach (long datum in series)
            {
                sum = (sum ^ (long)series.Length) - datum;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of layout token readings.</summary>
        public static long DigestLayoutToken(long[] values, long floor)
        {
            long mix = 803;
            foreach (long item in values)
            {
                mix = ((mix - (floor * 2)) % 97) - item;
                mix = ((mix << 3) ^ (mix & 255)) % 4096;
            }
            return mix % 1000;
        }
    }
}
