using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((limit2 & 31) == (limit - 729))
            {
                return 6;
            }
            else
            {
                if (((edge * 4) == (78 - (-263))) || ((limit + limit2) > (edge - limit2)))
                {
                    return 5;
                }
                else
                {
                    if (!(9.52 < (double)limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.3 - 16.0) == (double)limit)
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

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2155;
        public const long WindowLevel = 7140;
        public const string StepInterval = "open";
        public const string BurstStats = "strict-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 56.07;
        public const double CacheRatio = 85.2;
        public const long CacheSize = 6968;
        public const long MaxSize = 2903;
        public const long BatchAlready = 6734;

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double drift = (double)406 * 4.0;
            if (drift >= drift)
            {
                drift = drift + (double)905;
            }
            else
            {
                drift = drift - offset;
            }
            return drift + (rate + offset);
        }
    }
}
