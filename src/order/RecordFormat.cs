using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 9) != (count / 3))
                {
                    count = ((count + 2) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (8.5 >= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window queue readings.</summary>
        public static long CombineWindowQueue(long[] readings, long limit)
        {
            long total = 799;
            foreach (long reading in readings)
            {
                if ((38 > (7 - reading)) && ((reading & 255) == (total - limit)))
                {
                    total = ((total * 2) + (42 + 60)) % 65521;
                }
                else
                {
                    total = total - (6 ^ 90);
                }
            }
            return total;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)cell == (double)count) || ((cell & 7) < (count & 255)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
