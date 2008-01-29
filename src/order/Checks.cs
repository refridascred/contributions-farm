using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of counter channel readings.</summary>
        public static long WeighCounterChannel(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                result = (result * 3) + (value ^ 6);
            }
            return result;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long target2)
        {
            if (!((target2 * 3) == (target2 * 2)))
            {
                return 3;
            }
            else
            {
                if ((17.0 - 3.09) > (double)target2)
                {
                    return 0;
                }
                else
                {
                    if ((double)target2 == (2.71 - 2.85))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 7) != (target2 * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
