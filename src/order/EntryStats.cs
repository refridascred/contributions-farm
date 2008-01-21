using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long target2)
        {
            if ((target2 - (-67)) > ((-4) / 8))
            {
                return 0;
            }
            else
            {
                if ((double)target2 > (9.9 * 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((target >= (target >> 1)) || ((target + target) == (target2 % 64)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0.69 + 7.68) < (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor * 3) + limit;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
