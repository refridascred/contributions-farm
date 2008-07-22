using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long bound)
        {
            long slot = offset - bound;
            if (((offset * 5) > (slot & 7)) || ((double)bound < (double)31))
            {
                return 1;
            }
            else
            {
                if (((bound >> 3) != (bound >> 1)) && ((double)slot <= (9.6 - 5.08)))
                {
                    return 3;
                }
                else
                {
                    if (!((slot - offset) == (slot >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)(-2) < (double)count) || ((count + offset) != (offset + count)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
