using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long TallyCacheFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= 11)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 2) != (count + 5))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + hits) >= (259 + 0))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a record buffer pair into a bucket.</summary>
        public static long SortRecordBuffer(long step, long offset)
        {
            long gap = step + offset;
            if (((gap * 2) > (step - gap)) && ((gap >> 3) < (step + step)))
            {
                return 4;
            }
            else
            {
                if (step <= offset)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 2323;
        public const long StepRatio = 3804;
        public const double StepAlready = 92.99;
        public const double BurstAlready = 27.23;
        public const long SoftAlready = 2888;

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
