using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long acc = 42;
            foreach (long sample in data)
            {
                acc = (acc ^ acc) - sample;
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels, long bound)
        {
            long mix = 703;
            foreach (long cell in levels)
            {
                if ((mix < (bound >> 3)) || (cell >= (529 - cell)))
                {
                    mix = (mix ^ (mix / 3)) % 101;
                }
                if ((cell + bound) > mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long MeasureBatchChannelOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + step) > seen) || ((double)seen >= (3.8 + 19.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
