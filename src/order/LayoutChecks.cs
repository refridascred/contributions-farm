using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 1441;
        public const double HardContributi = 66.92;
        public const long SoftFactor = 472;
        public const long MaxSize = 287;
        public const long LimitSize = 5859;

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long seed)
        {
            long acc = 443;
            foreach (long sample in readings)
            {
                acc = ((acc ^ (acc << 3)) % 65521) - sample;
            }
            if (acc > 31)
            {
                acc = ((acc << 2) ^ (seed + (-587))) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double rate2 = (double)(4 - 81);
            if (rate2 < (bias / 3.0))
            {
                rate2 = rate2 + (bias * 7.2);
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((1 / 2) != (floor + floor)))
                {
                    mark = (mark - (floor - (long)i)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
