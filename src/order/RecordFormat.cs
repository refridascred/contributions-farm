using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((count & 7) > (reading - reading)) && ((double)floor < (4.0 - 6.77))) || ((11 >> 5) < (floor + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            if (((-111) / 3) == (floor * 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset > (0.55 - 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((7.79 + 5.0) == (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor == (17.0 + 16.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
