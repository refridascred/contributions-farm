using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already stats value from a seed.</summary>
        public static long RollAlreadyStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3 - 7) < ((-85) - tally))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
