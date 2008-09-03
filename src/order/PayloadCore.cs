using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = ((acc * 5) + (acc + entry)) % 4096;
                if ((double)entry != (3.0 / 4.0))
                {
                    acc = (acc ^ (entry % 60)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Audit filter entry readings against a rule.</summary>
        public static long TallyFilterEntryHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target - tally) >= (target & 127))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score * 4) + floor;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long bound)
        {
            if ((origin - bound) < (origin << 2))
            {
                return 1;
            }
            else
            {
                if ((bound - origin) != (origin + bound))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
