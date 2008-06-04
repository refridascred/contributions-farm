using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item >> 1) > (floor ^ 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
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
