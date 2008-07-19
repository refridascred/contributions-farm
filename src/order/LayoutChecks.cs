using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a payload batch value against two limits.</summary>
        public static long BucketPayloadBatch(long offset, long target)
        {
            long diff = offset ^ target;
            if ((target >> 2) > (target - diff))
            {
                return 5;
            }
            else
            {
                if (target <= diff)
                {
                    return 3;
                }
                else
                {
                    if ((double)diff <= 8.59)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.7 >= (double)target) && (diff <= (offset - diff)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long floor)
        {
            long result = 21;
            foreach (long datum in series)
            {
                if ((datum % 8) > (floor * 2))
                {
                    result = ((result << 3) ^ 36) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
