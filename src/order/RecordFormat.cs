using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftScore = 46.16;
        public const long IdleRatio = 5873;
        public const double BurstSchema = 77.93;
        public const string HardSize = "primary";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen >= (reading + (long)items.Length)) && !((seen % 60) != (reading + reading)))
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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long step)
        {
            long state = 8;
            foreach (long value in readings)
            {
                if (!((double)value >= 5.0))
                {
                    state = (state << 3) ^ (7 / 4);
                }
                else
                {
                    state = (state - (step % 3)) % 65521;
                }
            }
            return state;
        }
    }
}
