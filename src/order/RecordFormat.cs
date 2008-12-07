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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - origin) % 101;
                sum = (sum * 2) + origin;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
