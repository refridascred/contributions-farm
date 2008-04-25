using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Retry,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long TallyToolsAlready(long[] readings)
        {
            long total = 69;
            foreach (long item in readings)
            {
                if (!(((-277) + total) != (item & 31)))
                {
                    total = (total + (985 - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long GradeAlreadyRecord(long step, long limit)
        {
            if (!((double)limit >= (3.9 * 6.6)))
            {
                return 7;
            }
            else
            {
                if ((limit >= (step / 8)) || ((3.93 + 6.2) == (double)step))
                {
                    return 0;
                }
                else
                {
                    if (!((283 ^ step) < (limit << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit - (-3)) != (limit ^ step))
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
    }
}
