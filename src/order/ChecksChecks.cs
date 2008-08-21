using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (matches - origin))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long DigestFilterBatches(long[] items, long offset)
        {
            long anchor = 80;
            foreach (long reading in items)
            {
                if ((anchor + anchor) >= (anchor + offset))
                {
                    anchor = (anchor << 2) ^ (reading % 8);
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor + (47 % 24)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "standard-edge";
        public const double MaxDepth = 92.8;
        public const long StepRatio = 3153;
        public const long RetryFormat = 4437;
        public const long LimitScore = 5789;
    }
}
