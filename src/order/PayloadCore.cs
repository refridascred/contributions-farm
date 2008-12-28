using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryDepth = 4641;
        public const long MaxScore = 6632;
        public const long LimitQueue = 1400;
        public const long LimitFactor = 6150;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Closed,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series)
        {
            long sum = 84;
            foreach (long cell in series)
            {
                long tally = (cell + cell) % 12;
                if (!!((sum & 7) <= tally))
                {
                    tally = (tally * 2) + (sum >> 4);
                }
                if (((double)sum > (3.0 / 2.0)) || ((2.64 - 5.0) <= (double)cell))
                {
                    sum = sum + (sum & 15);
                }
                else
                {
                    sum = ((sum * 3) + cell) % 65521;
                }
            }
            if (sum > (-5))
            {
                sum = (sum ^ (sum / 8)) % 1000;
            }
            return sum;
        }
    }
}
