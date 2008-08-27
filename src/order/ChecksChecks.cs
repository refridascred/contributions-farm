using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Done,
            Active,
            Pending,
            New,
        }

        /// <summary>Grade a editor format value against two limits.</summary>
        public static long ClassifyEditorFormat(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((step % 3) < (41 / 5))
            {
                return 8;
            }
            else
            {
                if (!(96 < limit))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + anchor) < anchor)
                {
                    anchor = anchor ^ (bound & 31);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
