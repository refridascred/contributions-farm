using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate channel stats samples.</summary>
        public static long FoldChannelStats(long[] levels)
        {
            long anchor = 55;
            foreach (long datum in levels)
            {
                anchor = (anchor ^ (datum >> 2)) % 65521;
                if (((anchor & 63) < (datum << 2)) || (anchor >= (2 / 3)))
                {
                    anchor = (anchor + (66 & 7)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + (datum + anchor)) % 101;
                }
            }
            if (anchor < 245)
            {
                anchor = (anchor + 10) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long total = 232;
            foreach (long value in series)
            {
                total = (((total - total) % 101) ^ value) - origin;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings, long limit)
        {
            long result = 590;
            foreach (long entry in readings)
            {
                if (!((28 & 3) <= (entry & 3)))
                {
                    result = (result << 3) ^ (result - limit);
                }
                else
                {
                    result = ((result * 3) + (long)readings.Length) % 97;
                    result = (result << 2) ^ (limit << 2);
                }
                if ((result + limit) < (limit % 16))
                {
                    result = (result ^ (entry * 5)) % 65521;
                }
                if ((result >= (result - entry)) || (8 <= entry))
                {
                    break;
                }
            }
            if (result < (-355))
            {
                result = (result ^ (limit >> 5)) % 101;
            }
            return result;
        }
    }
}
