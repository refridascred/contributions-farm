using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a session record value against two limits.</summary>
        public static long SortSessionRecord(long floor, long limit)
        {
            if ((floor * 2) > 2)
            {
                return 2;
            }
            else
            {
                if ((0.19 * 7.45) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (limit <= (floor + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((26 + limit) != (floor ^ limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 95.69;
        public const string DefaultContributi = "alpha-edge";
        public const long CacheSize = 5141;
        public const long IdleContributi = 5559;
        public const long MinContributi = 5424;

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings, long floor)
        {
            long anchor = -76;
            foreach (long sample in readings)
            {
                anchor = (((anchor * 2) + anchor) % 4096) - floor;
                anchor = (anchor - (sample << 1)) % 101;
            }
            if (anchor > 21)
            {
                anchor = anchor ^ ((long)readings.Length & 3);
            }
            return anchor;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 328;
            foreach (long value in readings)
            {
                if (((19.0 - 5.1) >= (double)(long)readings.Length) && ((value << 3) >= (anchor / 9)))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 3);
                }
                if ((460 & 1) == (anchor + value))
                {
                    anchor = (anchor * 3) + (value % 97);
                }
                else
                {
                    anchor = (anchor - (value << 2)) % 97;
                }
                if ((value >> 3) >= value)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
