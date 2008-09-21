using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(29 <= reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix - (origin + mix)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long target2)
        {
            if ((target2 >> 4) >= target)
            {
                return 5;
            }
            else
            {
                if ((double)target <= (3.68 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((target2 * 2) > target2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 + target) >= ((-24) + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
