using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items)
        {
            long acc = 500;
            foreach (long cell in items)
            {
                acc = (acc ^ (cell + acc)) % 97;
                if (!((acc / 4) < acc))
                {
                    acc = (acc + (acc + cell)) % 1000;
                }
                else
                {
                    acc = ((acc * 5) + (cell - (long)items.Length)) % 65521;
                }
            }
            return acc;
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
