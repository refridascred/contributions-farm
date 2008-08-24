using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format account entries that pass the check.</summary>
        public static long MeasureFormatAccountHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + count) != (reading << 1))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (anchor & 63)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                long delta = (floor - result) + result;
                if ((double)result == (2.97 + 0.46))
                {
                    break;
                }
                else
                {
                    result = (result * 2) + (delta - delta);
                    delta = delta ^ (floor & 1);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
