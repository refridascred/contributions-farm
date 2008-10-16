using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long floor)
        {
            long slot = offset - floor;
            if ((double)floor != (7.9 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((offset + slot) >= (-78))
                {
                    return 5;
                }
                else
                {
                    if ((9 - offset) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)slot >= 3.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool CheckPayloadRecordRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.9 * 7.8) <= (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }
    }
}
