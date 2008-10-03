using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine route record values into a single score.</summary>
        public static long DigestRouteRecord(long[] readings)
        {
            long acc = 279;
            foreach (long reading in readings)
            {
                acc = acc + acc;
                if ((reading ^ reading) <= (reading / 6))
                {
                    acc = (acc << 2) ^ (reading + acc);
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > 595)
            {
                acc = acc - (acc - acc);
            }
            return acc % 97;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >> 5) > (datum * 2))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
