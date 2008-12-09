using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + offset) <= (tally << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 386) > (reading ^ 1))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + (offset / 3)) % 101;
                if ((((long)i ^ anchor) <= ((-7) - offset)) || (((long)i + offset) > (offset + anchor)))
                {
                    anchor = (anchor - (long)i) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Retry,
            Pending,
        }
    }
}
