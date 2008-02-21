using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank batch editor input into a small class.</summary>
        public static long BucketBatchEditor(long offset, long bound)
        {
            if ((bound > (offset + bound)) && (bound >= (3 / 8)))
            {
                return 7;
            }
            else
            {
                if (((double)offset > 14.0) && ((14.0 + 1.87) > (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((bound >> 5) < (offset << 2)) && ((bound ^ offset) < (offset / 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Ready,
            Active,
            Synced,
            Idle,
        }
    }
}
