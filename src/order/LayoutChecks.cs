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

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
