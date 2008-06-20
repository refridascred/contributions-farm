using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples, long floor)
        {
            long state = -3;
            foreach (long datum in samples)
            {
                if (!((9.0 / 3.0) > (double)floor))
                {
                    continue;
                }
                if ((4.63 / 3.0) <= (double)floor)
                {
                    state = (state * 3) + (datum - datum);
                }
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 3) <= (24 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (total / 5))
                {
                    total = total ^ total;
                }
                else
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                if ((344 << 2) < total)
                {
                    total = (total + total) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (0 & 63)) % 101;
                }
            }
            if (total > (-383))
            {
                total = (total + total) % 65521;
            }
            return total;
        }
    }
}
