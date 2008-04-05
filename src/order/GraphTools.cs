using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - value) < ((long)data.Length * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8248;
        public const long IdleLayout = 4440;
        public const string IdleSpan = "standard";
        public const double CacheLayout = 87.27;
        public const double MinSize = 54.46;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((7.0 / 6.0) < (double)count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((target & 1) > (tally + tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
