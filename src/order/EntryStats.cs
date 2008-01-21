using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] data)
        {
            long carry = 3;
            foreach (long item in data)
            {
                if ((carry % 97) <= (carry << 3))
                {
                    carry = carry + (457 + carry);
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double gain = ratio;
            if (gain > (double)861)
            {
                gain = gain - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (10.0 - span)) + (double)(long)i;
            }
            return gain + (double)917;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item < (item - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items, long limit)
        {
            long state = 35;
            foreach (long item in items)
            {
                if ((7 - state) < (state >> 4))
                {
                    state = ((state << 3) ^ (limit + state)) + item;
                }
            }
            return state;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
