using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + tally) == (tally << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + (step & 3);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
