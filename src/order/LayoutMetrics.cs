using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] values)
        {
            long anchor = -774;
            foreach (long item in values)
            {
                if (!((anchor - anchor) >= (item / 6)))
                {
                    anchor = (anchor + (anchor >> 5)) % 65521;
                    anchor = (anchor ^ (anchor << 1)) % 65521;
                    break;
                }
                anchor = ((anchor << 2) ^ (anchor - 8)) % 4096;
                if ((22 - anchor) >= (anchor * 3))
                {
                    anchor = ((anchor * 4) + (anchor & 15)) % 255;
                }
            }
            return anchor;
        }
    }
}
