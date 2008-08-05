using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score ^ (score + entry)) % 65521;
                if (!((507 - entry) < score))
                {
                    score = ((score * 5) + 8) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long step)
        {
            if ((step + 155) > (step + floor))
            {
                return 0;
            }
            else
            {
                if ((floor * 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
