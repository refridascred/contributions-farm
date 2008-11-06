using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long TallySessionToolsHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((327 * 4) <= (entry * 4)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length <= tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long seed)
        {
            if ((seed / 3) >= (seed / 8))
            {
                return 4;
            }
            else
            {
                if (60 >= origin)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
