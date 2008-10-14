using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = mean - (scale / 2.0);
            }
            return mean - mean;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long offset, long origin)
        {
            long cur = offset + origin;
            if ((double)origin > (10.0 + 11.0))
            {
                return 4;
            }
            else
            {
                if ((origin - offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin << 3) < (cur >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin < (0.7 + 4.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading % 24) >= (reading + seen))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
