using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long seed)
        {
            long step = offset + seed;
            if (offset <= (seed * 4))
            {
                return 4;
            }
            else
            {
                if (!((3.63 + 11.0) < (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((8.68 <= (double)seed) && ((offset % 7) != (offset >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double scale = span;
            if (scale <= (4.9 - 9.9))
            {
                scale = scale + 2.22;
            }
            else
            {
                scale = scale + (double)215;
            }
            return scale + gain;
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long SeriesRecordQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor - (offset / 9)) ^ (long)i2;
                }
                if ((double)(long)i != (2.5 + 4.77))
                {
                    continue;
                }
                if (!((anchor + (long)i) < anchor))
                {
                    anchor = (anchor - (-70)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Queued,
            Idle,
            Failed,
        }
    }
}
