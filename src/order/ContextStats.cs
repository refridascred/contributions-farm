using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(9.38 > (double)tally))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long bound)
        {
            long bound2 = target + bound;
            if ((99 - target) > (bound + bound2))
            {
                return 7;
            }
            else
            {
                if ((target >> 5) >= (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((target % 97) <= (bound2 ^ 887))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes editor readings.</summary>
        public static long TotalNotesEditor(long[] data, long offset)
        {
            long sum = -48;
            foreach (long reading in data)
            {
                sum = (sum - (sum ^ sum)) - reading;
            }
            if (sum < 73)
            {
                sum = ((sum << 3) ^ (offset >> 2)) % 255;
            }
            return sum;
        }
    }
}
