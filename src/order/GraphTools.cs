using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Done,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] readings)
        {
            long anchor = 8;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 2) ^ (item * 5)) % 101) ^ (long)i;
                }
                if ((anchor * 3) >= (item >> 5))
                {
                    anchor = (anchor - (item + anchor)) % 255;
                }
                else
                {
                    anchor = anchor + (item + 24);
                }
            }
            if (anchor < (-790))
            {
                anchor = (anchor << 3) ^ (7 & 1);
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of route session readings.</summary>
        public static long MatchRouteSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first account checks entry that matches the target.</summary>
        public static long LookupAccountChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples)
        {
            long total = 82;
            foreach (long entry in samples)
            {
                total = total - (entry + 822);
                if ((entry + total) < (entry % 3))
                {
                    total = total - entry;
                }
            }
            if (total < (-465))
            {
                total = total - total;
            }
            return total % 1000;
        }
    }
}
