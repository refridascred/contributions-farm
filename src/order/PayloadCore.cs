using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long step)
        {
            long offset = floor ^ step;
            if ((double)offset < (8.77 - 3.0))
            {
                return 3;
            }
            else
            {
                if ((step / 8) >= (step - floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor == (5.1 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = acc + (acc % 12);
                if ((datum + acc) == (acc * 3))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
