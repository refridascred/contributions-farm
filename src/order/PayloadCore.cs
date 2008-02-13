using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((41 & 127) != (entry + 14)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long floor)
        {
            long prev = limit - floor;
            if (((68 * 5) == (limit ^ floor)) || ((floor % 8) < 5))
            {
                return 1;
            }
            else
            {
                if (20.0 >= (double)prev)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= 0.6)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor / 2) >= (limit & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Dropped,
            Idle,
            Pending,
            Draft,
        }
    }
}
