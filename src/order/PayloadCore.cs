using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long state = 28;
            foreach (long cell in items)
            {
                if ((limit > 11) && ((double)limit < (16.0 / 4.0)))
                {
                    continue;
                }
                state = (state * 2) + (cell + limit);
            }
            return state;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
