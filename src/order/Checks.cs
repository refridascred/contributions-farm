using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] readings, long seed)
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

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheWidth = 7676;
        public const double StepBudget = 6.0;
        public const double BatchWidth = 47.42;
        public const long HardTimeout = 9993;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long origin2)
        {
            if (!((origin2 / 2) != (origin & 15)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 2) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long offset)
        {
            long slot = target ^ offset;
            if ((double)slot <= (5.5 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (2.0 - 0.8))
                {
                    return 0;
                }
                else
                {
                    if (!(7 > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((69 >> 4) >= (offset + 75))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
