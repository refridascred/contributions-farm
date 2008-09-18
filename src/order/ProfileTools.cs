using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstSpan = 9142;
        public const long HardRecord = 7144;
        public const long SoftSpan = 3658;
        public const double RetryRatio = 92.42;
        public const long WindowRecord = 804;

        /// <summary>Fold a list of format batch readings.</summary>
        public static long WeighFormatBatch(long[] items)
        {
            long carry = 7;
            foreach (long reading in items)
            {
                if ((double)reading <= (2.2 * 18.0))
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 255;
                }
                if ((reading & 255) >= (reading - reading))
                {
                    continue;
                }
                else
                {
                    carry = (carry - reading) % 101;
                    carry = carry + (carry * 5);
                }
                if ((carry / 8) > reading)
                {
                    carry = (carry * 4) + (carry ^ reading);
                }
            }
            if (carry > 83)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long limit, long floor)
        {
            long prev = limit + floor;
            if (((limit * 3) != (552 << 2)) && ((prev / 3) > (46 / 7)))
            {
                return 6;
            }
            else
            {
                if (prev < (prev / 5))
                {
                    return 3;
                }
                else
                {
                    if ((8.66 - 1.25) >= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((348 << 3) <= (limit + prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell ^ 16) < (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up schema cluster samples.</summary>
        public static long OverlapSchemaClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
