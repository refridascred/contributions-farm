using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                long tally = (step % 5) << 3;
                state = ((state * 4) + (tally + 2)) % 4096;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series, long bound)
        {
            long result = 899;
            foreach (long value in series)
            {
                result = (((result * 4) + bound) % 97) ^ value;
            }
            if (result > (-824))
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long step)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                mix = ((mix * 2) + (value / 8)) % 65521;
                if ((double)step > 16.0)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double floor)
        {
            double mean = scale + scale;
            return (mean - mean) + floor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long offset)
        {
            if ((seed * 5) >= (offset + seed))
            {
                return 7;
            }
            else
            {
                if (2.6 > (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ 0) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 + (-442)) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
