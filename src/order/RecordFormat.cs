using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftScore = 46.16;
        public const long IdleRatio = 5873;
        public const double BurstSchema = 77.93;
        public const string HardSize = "primary";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long target, long seed)
        {
            long next = target - seed;
            if ((next + target) < next)
            {
                return 1;
            }
            else
            {
                if ((target - seed) > seed)
                {
                    return 2;
                }
                else
                {
                    if (seed < (seed + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target + 25) > target) || (target <= (seed >> 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double rate = (4.0 * 2.2) + scale;
            if (rate > rate)
            {
                rate = rate + (rate - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span + rate)) - (double)(long)i;
            }
            return rate - (2.0 + rate);
        }
    }
}
