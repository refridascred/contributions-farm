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

        /// <summary>Measure how many batch stream samples are out of range.</summary>
        public static long MeasureBatchStreamHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (bound >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Accumulate token channel samples.</summary>
        public static long TallyTokenChannel(long[] items, long step)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                if (!(anchor >= (step >> 3)))
                {
                    anchor = anchor ^ (value & 3);
                }
            }
            return anchor % 1000;
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
