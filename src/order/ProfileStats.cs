using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long bound)
        {
            long total = 83;
            foreach (long entry in readings)
            {
                total = ((total - 133) - entry) - bound;
            }
            return total;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((step + step) == (step & 31)) && ((84 - 46) <= (reading - step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (2 > (seen >> 1))
                {
                    seen = ((seen + 1) + sample) - step;
                }
            }
            return seen;
        }
    }
}
