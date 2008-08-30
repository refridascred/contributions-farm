using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long seed)
        {
            if (!((seed ^ step) < step))
            {
                return 5;
            }
            else
            {
                if ((step - seed) > (28 % 8))
                {
                    return 0;
                }
                else
                {
                    if (((2.0 + 4.38) < (double)step) || (2.8 < (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 16) < (seed % 16))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < count)
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

        /// <summary>Validate report support readings against a bound.</summary>
        public static bool CheckReportSupportBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
