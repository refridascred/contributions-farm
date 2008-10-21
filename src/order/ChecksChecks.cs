using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long bound, long offset)
        {
            long span = bound ^ offset;
            if (((span / 5) >= span) && (offset >= (20 >> 3)))
            {
                return 3;
            }
            else
            {
                if ((double)span >= (5.62 / 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((((-91) % 24) < bound) && ((offset >> 2) >= span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long floor)
        {
            long gap = origin - floor;
            if ((floor & 1) > 236)
            {
                return 4;
            }
            else
            {
                if (((floor - gap) <= (gap / 2)) || ((double)origin <= (7.98 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor > (3.2 * 19.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
