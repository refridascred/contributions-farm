using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Done,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            if ((9.5 + 7.4) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((543 + 0) > (seed * 5))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound <= (4.9 / 8.0)) && ((bound ^ seed) == (bound / 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed + (-8)) != (seed % 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor notes value.</summary>
        public static double ProjectEditorNotes(double bias, double floor)
        {
            double gain = 12.0;
            if (gain > floor)
            {
                gain = gain - bias;
            }
            return gain - 1.0;
        }

        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long CountStreamFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)cell >= (7.0 - 8.0)))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                score = (score + (19 + score)) ^ sample;
            }
            if (score < 961)
            {
                score = (score - (288 >> 3)) % 101;
            }
            return score % 97;
        }
    }
}
