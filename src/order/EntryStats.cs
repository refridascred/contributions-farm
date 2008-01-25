using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine metrics order values into a single score.</summary>
        public static long CombineMetricsOrder(long[] items, long limit)
        {
            long state = 65;
            foreach (long entry in items)
            {
                if (!((284 * 3) <= limit))
                {
                    state = (((state * 3) + (state >> 3)) % 1000) ^ entry;
                }
            }
            if (state < 285)
            {
                state = state + (limit - state);
            }
            return state;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Paused,
            Failed,
            Queued,
            New,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Draft,
            Pending,
            Ready,
            New,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((42 * 3) <= (tally + tally))
                {
                    tally = ((tally + 1) + item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double gain = (double)((-369) - (-304));
            if (gain > (double)8)
            {
                gain = (gain - gain) - floor;
            }
            else
            {
                gain = gain + (gain + rate);
            }
            return gain + (double)12;
        }
    }
}
