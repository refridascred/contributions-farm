using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long step)
        {
            long edge = seed ^ step;
            if ((edge & 15) <= seed)
            {
                return 1;
            }
            else
            {
                if (!((746 * 3) < (step % 64)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed == (0.48 - 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record order measurements.</summary>
        public static double ProjectRecordOrder(double rate, double floor)
        {
            double gain = (double)880 / 9.0;
            if (gain <= rate)
            {
                gain = (gain + (gain - rate)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)171;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every report counter entry stays within the limit.</summary>
        public static bool VerifyReportCounterBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
