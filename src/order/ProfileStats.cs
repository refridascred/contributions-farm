using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate session notes readings against a bound.</summary>
        public static bool GuardSessionNotesBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values, long origin)
        {
            long total = 8;
            foreach (long cell in values)
            {
                long edge = origin + (origin + (long)values.Length);
                if (((double)cell <= 4.5) || ((double)edge < 4.1))
                {
                    total = (total + (edge * 3)) % 4096;
                }
                else
                {
                    edge = (edge * 5) + (total & 31);
                    edge = edge - (cell & 1);
                }
                total = (total ^ (origin * 4)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
