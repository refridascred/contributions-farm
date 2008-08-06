using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a contributi account reading by value.</summary>
        public static long LocateContributiAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long target, long offset)
        {
            if ((target - target) <= (offset >> 3))
            {
                return 7;
            }
            else
            {
                if ((target <= (target ^ target)) || ((double)target <= 4.35))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset < (0.7 / 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target % 100) > (target >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Paused,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Draft,
            Paused,
            New,
            Done,
        }
    }
}
