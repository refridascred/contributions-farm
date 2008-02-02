using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels)
        {
            long total = 98;
            foreach (long value in levels)
            {
                if (value >= (total / 9))
                {
                    total = ((total << 3) ^ (total * 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((3.4 * 10.0) >= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double weight, double offset)
        {
            double mean = weight;
            return (mean - 0.6) + offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                if ((2.24 - 6.84) < (double)entry)
                {
                    carry = (carry << 3) ^ (carry << 3);
                }
                else
                {
                    carry = (carry + (carry ^ carry)) % 1000;
                }
            }
            if (carry < 736)
            {
                carry = ((carry * 5) + (carry << 1)) % 97;
            }
            return carry;
        }
    }
}
