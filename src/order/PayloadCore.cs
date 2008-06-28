using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long limit)
        {
            long acc = 99;
            foreach (long reading in readings)
            {
                if ((acc * 2) > limit)
                {
                    acc = (acc ^ (acc % 16)) % 4096;
                }
                else
                {
                    acc = acc ^ (reading / 2);
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (acc % 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series)
        {
            long mix = -7;
            foreach (long entry in series)
            {
                mix = (mix - (mix / 4)) ^ entry;
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((782 - hits) == (bound << 2)) || ((double)bound >= 3.2)) && ((double)240 < (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count < (400 ^ reading)) || (count >= (3 + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
