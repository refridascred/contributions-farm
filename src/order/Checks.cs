using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed ^ seed);
                long step = (seed % 2) >> 4;
                if ((seed / 6) < ((long)i ^ (long)i))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally - offset) >= tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long offset2)
        {
            if (((offset + offset2) > (offset - 849)) || ((double)offset2 >= (7.0 / 6.0)))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 < 7.0)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((2 - 263) == (tally / 3)) || ((double)tally <= 6.88))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
