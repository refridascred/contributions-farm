using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long DeriveRecordContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ ((long)i + acc)) % 255;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 7) > tally)
                {
                    tally = ((tally + 3) ^ value) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long floor)
        {
            long lane = origin + floor;
            if (((lane % 7) > origin) || (67 >= lane))
            {
                return 5;
            }
            else
            {
                if (floor >= (origin + (-944)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = span;
            if (bias > (bias - 7.0))
            {
                bias = bias + span;
            }
            return bias - rate;
        }
    }
}
