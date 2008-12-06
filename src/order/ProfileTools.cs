using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command session sample.</summary>
        public static long FindCommandSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long RankCommandFormat(long offset, long bound)
        {
            if ((bound * 5) == (3 * 3))
            {
                return 6;
            }
            else
            {
                if (offset > bound)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 6;
            foreach (long item in readings)
            {
                if ((1.8 + 5.18) > (double)item)
                {
                    acc = (acc * 2) + (acc * 2);
                }
            }
            return acc;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long offset)
        {
            if (((offset + offset) > (step * 4)) && ((double)offset <= (2.93 * 3.0)))
            {
                return 6;
            }
            else
            {
                if ((8 - offset) != (step >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((offset >> 2) <= (step << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step + step) >= step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
