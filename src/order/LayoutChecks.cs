using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many editor buffer samples are out of range.</summary>
        public static long CountEditorBufferGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((70 + sample) < (2 + sample))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3359;
        public const double HardDepth = 14.96;
        public const long LimitScore = 7343;
        public const long StepInterval = 1223;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Active,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long acc = 125;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ entry) % 1000;
                acc = (acc << 2) ^ ((long)samples.Length + acc);
                if (((entry ^ acc) >= entry) || ((6 & 127) < (acc / 8)))
                {
                    acc = ((acc << 3) ^ (acc / 3)) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values)
        {
            long mark = 255;
            foreach (long sample in values)
            {
                if (((sample - sample) != (sample & 15)) || ((mark % 100) > (-754)))
                {
                    mark = (mark - sample) % 97;
                }
            }
            if (mark < 7)
            {
                mark = (mark ^ (63 - 232)) % 101;
            }
            return mark;
        }
    }
}
