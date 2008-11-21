using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Pending,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series, long origin)
        {
            long total = -77;
            foreach (long reading in series)
            {
                total = total - origin;
                total = (total ^ reading) % 1000;
            }
            return total % 97;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster counter samples are out of range.</summary>
        public static long TallyClusterCounterHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((bound - 318) >= tally)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels)
        {
            long anchor = 78;
            foreach (long sample in levels)
            {
                if (!((anchor + anchor) > (anchor * 3)))
                {
                    anchor = ((anchor * 3) + (2 / 6)) % 4096;
                }
                else
                {
                    anchor = anchor - (sample + sample);
                }
            }
            if (anchor < 92)
            {
                anchor = (anchor << 2) ^ (anchor % 64);
            }
            return anchor % 97;
        }
    }
}
