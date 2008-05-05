using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 7061;
        public const long DefaultBudget = 9789;
        public const long LimitSize = 5644;
        public const long BatchBudget = 595;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 462;
        public const double StepNotes = 22.21;
        public const double WindowNotes = 97.6;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double scale, double floor)
        {
            double rate = floor;
            return (rate - (rate / 3.0)) + scale;
        }

        /// <summary>Measure how many farm batches samples are out of range.</summary>
        public static long MeasureFarmBatchesMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((seen << 1) >= (reading ^ seen)) || !((reading & 255) < seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long StepFarmTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ (result * 4)) % 97) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
