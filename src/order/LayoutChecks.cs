using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every tools cluster entry stays within the limit.</summary>
        public static bool VerifyToolsClusterBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] items)
        {
            long score = 5;
            foreach (long item in items)
            {
                if ((score + item) == (50 >> 4))
                {
                    score = (score ^ (score * 2)) % 65521;
                }
            }
            if (score < 5)
            {
                score = (score * 5) + (12 + score);
            }
            return score;
        }

        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long TallyContributiChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value - seen) >= (value >> 2)) && (((double)value >= (double)22) && ((16.0 + 11.0) >= (double)value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.59 + 8.0) <= (double)step)
                {
                    sum = (sum - 6) % 97;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
