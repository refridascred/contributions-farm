using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double gain, double offset)
        {
            double scale = offset;
            if (scale > offset)
            {
                scale = (scale + (double)525) + gain;
            }
            else
            {
                scale = scale + offset;
            }
            return scale + offset;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
