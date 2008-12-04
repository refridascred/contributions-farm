using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + tally) >= value) && ((value - 15) >= (579 - tally))) && (((double)tally != (double)value) && ((double)tally <= 6.41)))
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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > (entry >> 4))
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxFactor = 97.03;
        public const double MaxInterval = 15.77;
        public const long StepSpan = 3587;
        public const long HardContext = 5795;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long seed, long floor)
        {
            if ((floor <= seed) && ((double)floor > (4.43 / 2.0)))
            {
                return 2;
            }
            else
            {
                if ((70 >= seed) || ((seed - seed) != (7 + seed)))
                {
                    return 3;
                }
                else
                {
                    if ((seed < (seed + floor)) || ((seed % 7) < floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
