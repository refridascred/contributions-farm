using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many buffer counter samples are out of range.</summary>
        public static long TallyBufferCounterHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 5) == (floor + 54))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches < (2.0 + 1.0))
                {
                    matches = ((matches + 2) ^ datum) + origin;
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long limit)
        {
            if (((offset << 3) == (offset & 15)) || ((double)offset >= (8.15 + 5.0)))
            {
                return 7;
            }
            else
            {
                if (!((double)offset < (3.87 / 7.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((double)offset2 > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin * 4) != (5 & 63))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (4.92 * 6.03))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin < (offset - offset)) || ((7 - offset) != (origin * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
