using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long step)
        {
            long result = 566;
            foreach (long item in readings)
            {
                result = ((result * 5) + (step + item)) % 1000;
            }
            if (result > 312)
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long target)
        {
            long cur = step - target;
            if (((cur / 5) > target) && (target > (target * 3)))
            {
                return 8;
            }
            else
            {
                if (((double)cur == (6.8 * 9.0)) && ((target >> 2) < (target + step)))
                {
                    return 1;
                }
                else
                {
                    if (((0 + step) > step) || (214 <= cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur + step) != (cur - step))
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
    }
}
