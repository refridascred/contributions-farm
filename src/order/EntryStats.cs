using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double ratio2 = 16.0;
            if (ratio2 < (offset * 4.58))
            {
                ratio2 = (ratio2 + 2.0) - ratio;
            }
            return ratio2 + (double)(-49);
        }

        /// <summary>Classify a window route pair into a bucket.</summary>
        public static long SortWindowRoute(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((offset & 31) > (offset % 16))
            {
                return 3;
            }
            else
            {
                if ((origin - offset) <= (origin - span))
                {
                    return 1;
                }
                else
                {
                    if ((offset < (span - span)) && ((offset << 2) >= span))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((span >> 1) == (span ^ offset)) || ((8.0 / 5.0) > (double)span))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((926 + bound) >= (count / 6))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
