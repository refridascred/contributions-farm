using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (((58 / 8) == (5 + bound)) && (((-90) + bound2) > (bound + bound2)))
            {
                return 8;
            }
            else
            {
                if ((bound2 - 26) == (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 == (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (11.0 <= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
