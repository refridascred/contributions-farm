using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the profile buffer entries that pass the check.</summary>
        public static long TallyProfileBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (9.19 + 2.0))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long bound)
        {
            long slot = origin ^ bound;
            if ((7 - bound) >= (42 >> 5))
            {
                return 0;
            }
            else
            {
                if ((2.2 / 7.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((origin & 15) != (slot % 16)) || (((-554) ^ slot) < (slot + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((8.3 - 3.54) == (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double bias = (floor + 0.88) / 4.0;
            return (bias - floor) + weight;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
