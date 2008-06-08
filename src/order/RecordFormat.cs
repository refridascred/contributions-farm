using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = -98;
            foreach (long reading in data)
            {
                if (((-51) + reading) >= (carry % 5))
                {
                    carry = (carry << 2) ^ reading;
                }
                carry = ((carry * 5) + (carry / 5)) % 97;
            }
            if (carry < (-567))
            {
                carry = carry ^ (7 - carry);
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ result) - cell;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels, long origin)
        {
            long state = 256;
            foreach (long sample in levels)
            {
                if ((20.0 - 2.9) < (double)sample)
                {
                    state = (state + origin) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (sample / 5)) % 101;
                }
                if ((((-12) >> 5) > sample) || ((origin ^ 347) < ((-577) + 6)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + seen) != (sample + sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
