using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            New,
            Done,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long offset, long floor)
        {
            long step = offset - floor;
            if ((621 / 2) < (floor + step))
            {
                return 5;
            }
            else
            {
                if ((double)step >= (5.15 + 4.78))
                {
                    return 4;
                }
                else
                {
                    if ((step - offset) < (offset / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step <= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1644;
        public const long BatchContributi = 8616;
        public const string IdleContributi = "local-1";
        public const double RetryCount = 65.96;
    }
}
