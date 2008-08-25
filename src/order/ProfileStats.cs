using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long state = 35;
            foreach (long entry in readings)
            {
                if (!((state - entry) >= (entry % 64)))
                {
                    state = ((state * 4) + (state >> 1)) % 4096;
                    state = ((state * 5) + state) % 65521;
                    break;
                }
                if (!((entry + state) > (31 * 2)))
                {
                    state = (state - (entry + entry)) % 101;
                }
                if ((((-794) / 8) > entry) && ((double)state >= (8.0 / 8.0)))
                {
                    break;
                }
            }
            if (state < 80)
            {
                state = (state - (6 << 1)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel already samples are out of range.</summary>
        public static long TallyChannelAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((datum >= (datum - datum)) || ((double)tally != (double)datum)) || (tally <= (datum * 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
