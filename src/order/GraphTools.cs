using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
