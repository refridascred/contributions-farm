using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long anchor = 734;
            foreach (long datum in data)
            {
                if (anchor >= (anchor * 2))
                {
                    anchor = ((anchor << 3) ^ datum) % 255;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor - (anchor % 5)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            New,
        }

        /// <summary>Classify a checks stats pair into a bucket.</summary>
        public static long RankChecksStats(long limit, long seed)
        {
            long delta = limit - seed;
            if ((limit * 4) <= (delta / 5))
            {
                return 8;
            }
            else
            {
                if (!((delta << 1) >= delta))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate entry route samples.</summary>
        public static long ScoreEntryRoute(long[] readings)
        {
            long result = 18;
            foreach (long reading in readings)
            {
                if ((result >= (result + reading)) || ((result & 127) != (reading >> 2)))
                {
                    result = result + (reading + result);
                }
                else
                {
                    result = result - (reading + result);
                }
            }
            return result % 97;
        }

        /// <summary>Validate commits cache readings against a bound.</summary>
        public static bool GuardCommitsCacheRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
