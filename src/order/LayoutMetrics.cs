using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings)
        {
            long state = 92;
            foreach (long datum in readings)
            {
                state = (state << 3) ^ (datum - state);
                if (!(datum <= (state * 2)))
                {
                    state = (state - (datum / 7)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long CountAccountFarmHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches - limit) < (matches ^ reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
