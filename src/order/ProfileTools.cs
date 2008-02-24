using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long acc = -22;
            foreach (long datum in data)
            {
                acc = acc + (acc << 1);
                if (limit > (datum % 64))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series, long origin)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                mark = ((mark + (79 + reading)) % 97) - origin;
            }
            return mark;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 1382;
        public const long StepAccount = 6582;
        public const double MaxBudget = 25.52;
        public const long SoftRatio = 3535;
    }
}
