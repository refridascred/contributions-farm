using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long step, long offset)
        {
            if ((double)offset >= 9.8)
            {
                return 7;
            }
            else
            {
                if (((step >> 4) <= (offset << 2)) && ((24 + offset) > step))
                {
                    return 4;
                }
                else
                {
                    if (((588 << 3) >= (offset % 100)) && ((5.85 / 4.0) < (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= (3.4 * 0.14))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Dropped,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long bound2)
        {
            if ((double)bound >= (19.0 - 3.89))
            {
                return 4;
            }
            else
            {
                if (!((bound2 << 2) > (bound2 - 334)))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 % 60) >= bound2)
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

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin << 2) <= (origin >> 5)))
                {
                    acc = (acc * 5) + (long)i;
                    acc = (acc + origin) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
