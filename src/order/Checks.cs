using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample & 255) < tally)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long TallyContextBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen - datum) != (3 ^ datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
