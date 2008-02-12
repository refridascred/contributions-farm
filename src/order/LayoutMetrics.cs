using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels, long seed)
        {
            long total = -4;
            foreach (long cell in levels)
            {
                if ((seed % 2) == ((long)levels.Length - cell))
                {
                    total = ((total * 5) + cell) % 97;
                }
                if ((4.22 - 10.0) <= (double)seed)
                {
                    break;
                }
            }
            if (total < 77)
            {
                total = (total << 3) ^ ((long)levels.Length + seed);
            }
            return total % 65521;
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
