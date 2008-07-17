using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((carry + 14) < (22 - target)) && (1 >= ((long)i + carry)))
                {
                    carry = (carry * 2) + (target >> 3);
                }
                carry = (carry * 2) + carry;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry - target) - (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a token record figure with a bias.</summary>
        public static double SmoothTokenRecord(double bias, double floor)
        {
            double bias2 = (double)(260 + 9);
            for (int i = 0; i < 6; i++)
            {
                bias2 = (((bias2 + 7.0) + (double)(long)i) + bias) - floor;
            }
            return bias2 + 3.0;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((3.0 > (double)entry) || ((entry % 8) != (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
