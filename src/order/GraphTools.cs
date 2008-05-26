using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of layout session entries.</summary>
        public static long WeighLayoutSession(long[] items, long offset)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample % 64)) + offset;
            }
            if (anchor < 14)
            {
                anchor = (anchor + ((long)items.Length % 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long target)
        {
            long prev = offset + target;
            if (28 < (offset >> 3))
            {
                return 5;
            }
            else
            {
                if ((target + 33) >= (6 & 1))
                {
                    return 4;
                }
                else
                {
                    if ((923 >> 1) != (prev >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((11.0 - 4.27) < (1.4 / 7.0)) && ((seen < item) && (item <= (51 ^ (-25)))))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Draft,
            Paused,
            Failed,
            Synced,
        }
    }
}
