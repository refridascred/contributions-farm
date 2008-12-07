using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long offset)
        {
            if (((target + target) >= (offset << 3)) || (offset >= (offset + target)))
            {
                return 2;
            }
            else
            {
                if (!((offset - 431) < (offset >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + target) <= (offset % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - target) < (target + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - target) > target)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
