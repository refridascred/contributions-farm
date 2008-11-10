using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a stream payload pair into a bucket.</summary>
        public static long SortStreamPayload(long step, long target)
        {
            long bound = step + target;
            if (step > target)
            {
                return 1;
            }
            else
            {
                if ((bound - 23) == (target % 97))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 5) <= 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >> 1) == (step + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report record entries that pass the check.</summary>
        public static long TallyReportRecordGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((long)data.Length != (value + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
