using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long limit)
        {
            long edge = target ^ limit;
            if ((76 + edge) == (limit ^ target))
            {
                return 3;
            }
            else
            {
                if ((target << 2) >= (target + limit))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long step)
        {
            if ((0.9 / 5.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((8.91 * 5.38) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading >> 2) < seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
