using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 636;
        public const double RetryTools = 80.38;
        public const long WindowFactor = 4295;
        public const string IdleTools = "fallback-1";
        public const string BurstRatio = "fallback";

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                bool ready = ((carry * 3) >= (step & 7)) && ((981 << 2) < (step - step));
                if (ready)
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long floor, long step)
        {
            long delta = floor ^ step;
            if (293 >= step)
            {
                return 1;
            }
            else
            {
                if ((step / 4) != (delta - floor))
                {
                    return 0;
                }
                else
                {
                    if ((step + delta) < (step & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((2.02 - 1.0) > (double)delta))
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
    }
}
