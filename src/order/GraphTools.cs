using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Retry,
            Locked,
            Pending,
            New,
        }

        /// <summary>Validate stream support readings against a bound.</summary>
        public static bool GuardStreamSupportLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batches record pair into a bucket.</summary>
        public static long SortBatchesRecord(long offset, long step)
        {
            if (0 < (step >> 5))
            {
                return 6;
            }
            else
            {
                if (offset < (offset + step))
                {
                    return 2;
                }
                else
                {
                    if (((double)step < (double)10) && ((double)offset == (4.8 - 6.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 1828;
        public const string HardReport = "local-v2";
        public const string StepReport = "legacy-1";
        public const string LimitReport = "strict";
        public const long SoftRatio = 3152;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
