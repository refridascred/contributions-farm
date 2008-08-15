using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long limit)
        {
            long score = 79;
            foreach (long value in levels)
            {
                score = ((score + (score / 8)) + value) + limit;
            }
            return score;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long step)
        {
            long mix = 21;
            foreach (long datum in values)
            {
                if ((14 >> 2) <= (datum % 24))
                {
                    mix = ((mix << 2) ^ (mix & 1)) - step;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ 28) % 255;
            }
            return mix;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
