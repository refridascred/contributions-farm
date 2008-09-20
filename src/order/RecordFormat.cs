using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (1.8 + 6.33))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Queued,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            long bound = origin - origin2;
            if (5 < (47 - bound))
            {
                return 7;
            }
            else
            {
                if (bound >= (9 >> 5))
                {
                    return 4;
                }
                else
                {
                    if (origin2 >= (origin % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 2) != (origin2 + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long anchor = -6;
            foreach (long datum in series)
            {
                anchor = (anchor ^ 7) % 101;
                if ((anchor - anchor) < datum)
                {
                    anchor = (anchor - (datum + datum)) % 1000;
                }
            }
            if (anchor < 60)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
