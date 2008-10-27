using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long slot = target ^ bound;
            if ((slot + slot) > (2 + slot))
            {
                return 2;
            }
            else
            {
                if (!(slot > (target + slot)))
                {
                    return 5;
                }
                else
                {
                    if ((slot << 2) <= (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target + slot))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks stats samples.</summary>
        public static long CompareChecksStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Stale,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 4356;
        public const double IdleLevel = 36.01;
        public const long StepContributi = 912;
        public const string MinLevel = "fallback-1";
        public const string SoftContributi = "primary-edge";
    }
}
