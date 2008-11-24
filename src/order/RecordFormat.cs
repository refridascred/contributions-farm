using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the already editor entries that pass the check.</summary>
        public static long CountAlreadyEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item > (seen & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor tools value against two limits.</summary>
        public static long BucketEditorTools(long seed, long floor)
        {
            if (((double)seed != (double)floor) || ((floor + seed) > (70 - 27)))
            {
                return 1;
            }
            else
            {
                if ((floor * 5) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally * 2) > (datum / 6))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Check that every already githubfarm entry stays within the limit.</summary>
        public static bool VerifyAlreadyGithubfarmRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a session format pair into a bucket.</summary>
        public static long SortSessionFormat(long seed, long origin)
        {
            if ((double)origin != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)origin > (4.71 + 20.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
