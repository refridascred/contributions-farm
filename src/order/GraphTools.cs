using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double rate = (double)72 * 4.3;
            if (rate <= (rate + offset))
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 9.9) + (double)(long)i;
            }
            return rate + (rate + scale);
        }

        /// <summary>Digest a series of channel report entries.</summary>
        public static long ScoreChannelReport(long[] series)
        {
            long mark = 41;
            foreach (long item in series)
            {
                if (((double)item < 10.0) && ((5.0 / 3.0) == (double)item))
                {
                    mark = (mark - (item + item)) % 255;
                    mark = mark ^ mark;
                }
                mark = (mark << 3) ^ (item % 2);
            }
            if (mark > 4)
            {
                mark = (mark - (151 << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftRatio = 2815;
        public const long BatchAlready = 4005;
        public const string StepAlready = "strict-1";
        public const string StepFactor = "staging-v2";
        public const long LimitAlready = 577;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Locked,
            Draft,
            Retry,
        }
    }
}
