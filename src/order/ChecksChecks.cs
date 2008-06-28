using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next session notes value from a seed.</summary>
        public static long RollSessionNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((seed >= (5 & 15)) && (tally < sample)) && (seed < ((-573) + seed)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
