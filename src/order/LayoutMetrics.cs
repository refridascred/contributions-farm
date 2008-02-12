using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a farm tools reading by value.</summary>
        public static long SeekFarmToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values)
        {
            long result = 829;
            foreach (long cell in values)
            {
                if ((90 + (long)values.Length) == (result + result))
                {
                    result = ((result ^ (result + result)) % 65521) ^ cell;
                }
            }
            if (result < 8)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Dropped,
            Ready,
            Synced,
        }
    }
}
