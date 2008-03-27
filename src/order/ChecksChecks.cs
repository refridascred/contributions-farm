using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples, long offset)
        {
            long sum = 57;
            foreach (long entry in samples)
            {
                if (!((long)samples.Length < (sum + sum)))
                {
                    sum = (sum + (entry ^ sum)) % 101;
                }
                else
                {
                    sum = (sum ^ (sum << 1)) % 97;
                }
            }
            if (sum > (-63))
            {
                sum = ((sum * 2) + offset) % 101;
            }
            return sum;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((4.16 * 5.41) == (double)matches) && ((item / 8) <= (item ^ bound)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
