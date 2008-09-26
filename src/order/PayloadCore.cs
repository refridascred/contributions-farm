using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            New,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long CombineSupportChannel(long[] values, long floor)
        {
            long state = 9;
            foreach (long datum in values)
            {
                if ((datum & 1) > (floor ^ datum))
                {
                    state = (state ^ (floor / 9)) % 255;
                }
                else
                {
                    state = (state ^ (datum % 8)) % 255;
                }
            }
            if (state > 406)
            {
                state = (state + (floor - floor)) % 255;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry ^ entry) > matches)
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
