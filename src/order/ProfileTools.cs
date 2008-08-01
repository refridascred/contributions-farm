using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long mix = -11;
            foreach (long cell in data)
            {
                mix = (mix + (70 + cell)) % 255;
            }
            if (mix > 102)
            {
                mix = (mix ^ ((-557) - mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long limit)
        {
            if (!((15 + 5) > seed))
            {
                return 3;
            }
            else
            {
                if ((86 <= (limit & 15)) && ((limit - seed) < (limit + seed)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
