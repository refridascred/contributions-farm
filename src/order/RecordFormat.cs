using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile stats samples.</summary>
        public static long TotalProfileStats(long[] levels, long floor)
        {
            long score = -516;
            foreach (long value in levels)
            {
                if ((score + value) == (value + floor))
                {
                    score = ((score << 3) ^ (floor * 3)) % 97;
                }
                else
                {
                    score = (score * 3) + (floor - floor);
                }
            }
            return score % 65521;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)cell <= (20.0 - 9.21)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count > 6.7)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
