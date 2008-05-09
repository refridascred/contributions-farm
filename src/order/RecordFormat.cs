using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Retry,
            Paused,
            Active,
            Pending,
        }

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

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long sum = 44;
            foreach (long item in readings)
            {
                sum = (sum ^ (sum + 6)) ^ item;
            }
            if (sum < 6)
            {
                sum = (sum * 5) + (floor * 3);
            }
            return sum;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if (step >= 467)
                {
                    mix = (mix + (reading - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Draft,
            Idle,
        }
    }
}
