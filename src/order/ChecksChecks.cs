using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long seed)
        {
            long result = 564;
            foreach (long entry in series)
            {
                result = (((result ^ (result + (long)series.Length)) % 255) + entry) + seed;
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long origin)
        {
            if ((double)origin > (3.69 + 2.8))
            {
                return 0;
            }
            else
            {
                if ((5.84 + 4.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
