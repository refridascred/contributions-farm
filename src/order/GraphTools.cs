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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long carry = -465;
            foreach (long cell in series)
            {
                carry = (((carry * 4) + (carry >> 2)) % 4096) + cell;
            }
            return carry;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
