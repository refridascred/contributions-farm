using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items, long step)
        {
            long carry = 545;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry << 2) ^ (carry * 4)) - (long)i) - value;
                }
                carry = ((carry << 2) ^ (57 ^ step)) % 65521;
            }
            if (carry < (-520))
            {
                carry = (carry ^ (step >> 2)) % 255;
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) <= ((-6) * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
