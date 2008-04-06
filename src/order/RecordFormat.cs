using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Ready,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) == (cell ^ score))
                {
                    score = ((score << 3) ^ (long)data.Length) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Validate farm route readings against a bound.</summary>
        public static bool VerifyFarmRouteBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long WeighMetricsSchema(long[] samples)
        {
            long mix = -22;
            foreach (long item in samples)
            {
                if ((long)samples.Length == (78 - mix))
                {
                    mix = (mix ^ (mix - mix)) ^ item;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            if (mix > 14)
            {
                mix = mix - (mix + mix);
            }
            return mix % 4096;
        }
    }
}
