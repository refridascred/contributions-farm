using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every record buffer entry stays within the limit.</summary>
        public static bool GuardRecordBufferBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long limit)
        {
            long span = target - limit;
            if ((double)limit != (3.0 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((target * 5) == (limit << 1))
                {
                    return 4;
                }
                else
                {
                    if (target < span)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
