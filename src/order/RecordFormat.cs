using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((limit >> 3) <= (limit * 3))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 6935;
        public const long DefaultCount = 6873;
        public const long BasePayload = 8452;
        public const long SoftTimeout = 4342;
        public const string RetryCount = "stable-v2";

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((-9) + tally) <= (49 - cell)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long bound, long target)
        {
            long lane = bound ^ target;
            if ((lane * 4) <= (lane % 7))
            {
                return 2;
            }
            else
            {
                if (!((target ^ lane) < (bound - lane)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (8.2 - 1.39))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane << 2) <= (lane + lane))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
