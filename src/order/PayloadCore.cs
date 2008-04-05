using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Stale,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((count + limit) >= (-77)) || ((6.1 + 4.3) > (double)item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxRatio = "open";
        public const long StepToken = 3225;
        public const long CacheToken = 5418;
        public const double SoftToken = 94.61;

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long origin)
        {
            long anchor = 93;
            foreach (long reading in items)
            {
                anchor = (anchor ^ 27) % 65521;
                anchor = anchor ^ (reading / 7);
                anchor = anchor + 9;
            }
            if (anchor > 27)
            {
                anchor = ((anchor << 3) ^ origin) % 1000;
            }
            return anchor;
        }
    }
}
