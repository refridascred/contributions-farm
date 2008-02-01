using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((2.0 + 14.0) == (double)floor)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample > (count + (-1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long target)
        {
            if ((97 % 60) < target)
            {
                return 2;
            }
            else
            {
                if ((double)floor == (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((target / 7) != (floor >> 1)) && ((floor >> 5) <= (target ^ (-326))))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long step)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if ((-873) < ((long)values.Length + acc))
                {
                    acc = ((acc - (7 - step)) % 1000) + reading;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double ratio = (floor / 2.0) - rate;
            if (ratio <= 2.1)
            {
                ratio = ratio + (double)370;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)95) - (double)(long)i;
            }
            return ratio + (rate - floor);
        }
    }
}
