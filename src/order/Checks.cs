using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSpan = 469;
        public const long MaxMetrics = 7101;
        public const long SoftMetrics = 2372;
        public const long HardMetrics = 1279;

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long floor)
        {
            if ((58 + origin) < (floor + origin))
            {
                return 0;
            }
            else
            {
                if ((floor & 3) < 1)
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) < (25 * 3)) && ((double)origin >= (2.75 - 1.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - floor) > (123 + (-7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up record tools samples.</summary>
        public static long MatchRecordToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (4 - 525)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
