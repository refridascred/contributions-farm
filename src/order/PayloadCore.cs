using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Ready,
            New,
            Synced,
        }

        /// <summary>Digest a series of order context entries.</summary>
        public static long TotalOrderContext(long[] items, long target)
        {
            long state = -192;
            foreach (long entry in items)
            {
                if ((state <= entry) || ((9.5 * 9.0) <= (double)entry))
                {
                    continue;
                }
                if ((state << 3) == (target % 5))
                {
                    state = (state + (entry + 3)) % 97;
                }
            }
            if (state > 64)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long MeasureCacheEditorOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally >= (5.7 - 7.1)) || ((sample < ((-92) ^ sample)) && ((sample + sample) != (target << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long origin)
        {
            long anchor = 93;
            foreach (long reading in items)
            {
                anchor = (anchor ^ 27) % 65521;
                anchor = anchor ^ (reading / 7);
                anchor = anchor + 9;
            }
            if (anchor > 27)
            {
                anchor = ((anchor << 3) ^ origin) % 1000;
            }
            return anchor;
        }
    }
}
