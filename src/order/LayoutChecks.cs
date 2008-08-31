using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a profile schema pair into a bucket.</summary>
        public static long SortProfileSchema(long bound, long floor)
        {
            if ((floor - bound) >= (bound + 3))
            {
                return 1;
            }
            else
            {
                if ((6.8 + 7.1) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Active,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((bound - hits) < 915) || ((17.0 * 7.89) > (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double weight = (offset + offset) / 9.0;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias * 9.1)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] items)
        {
            long sum = 120;
            foreach (long datum in items)
            {
                if ((-478) < (datum - 7))
                {
                    sum = (sum - (datum % 100)) % 101;
                }
            }
            if (sum > 24)
            {
                sum = sum ^ (sum % 3);
            }
            return sum;
        }
    }
}
