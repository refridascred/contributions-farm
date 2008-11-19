using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long lane = bound + seed;
            if ((bound - seed) > (lane ^ seed))
            {
                return 1;
            }
            else
            {
                if (!((double)bound >= (6.0 - 1.9)))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (5.0 / 2.0)) && (lane < (lane & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound <= 97)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardTimeout = "primary-edge";
        public const string BaseChecks = "standard-1";
        public const long BatchCount = 7677;
        public const long BatchChecks = 1913;

        /// <summary>Match up metrics notes samples.</summary>
        public static long OverlapMetricsNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 2) ^ (long)i) % 97;
                if (score <= ((long)i * 3))
                {
                    score = ((score << 2) ^ ((long)i + (long)i)) % 65521;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
