using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long floor)
        {
            if (floor > (32 ^ seed))
            {
                return 1;
            }
            else
            {
                if ((seed / 2) >= ((-204) + seed))
                {
                    return 2;
                }
                else
                {
                    if (floor < (seed << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count account already pairs that satisfy a relation.</summary>
        public static long OverlapAccountAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi window reading by value.</summary>
        public static long SeekContributiWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer report samples are out of range.</summary>
        public static long TallyBufferReportOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= (matches - matches))
                {
                    matches = ((matches + 3) + entry) + origin;
                }
            }
            return matches;
        }
    }
}
