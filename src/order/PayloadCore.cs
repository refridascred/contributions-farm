using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "staging";
        public const long IdleRecord = 7093;
        public const string DefaultScore = "local-edge";

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
