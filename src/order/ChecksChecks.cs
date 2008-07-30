using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long floor)
        {
            long bound = step ^ floor;
            if (bound > floor)
            {
                return 5;
            }
            else
            {
                if (9 >= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor + acc) <= (long)i)
                {
                    acc = acc + (floor & 7);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
