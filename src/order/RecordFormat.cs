using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Iterate the contributi counter series from a seed.</summary>
        public static long SeriesContributiCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((double)score >= (14.0 * 2.65)) && ((score % 10) < (score << 2)))
                {
                    score = (score - score) % 97;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long state = 713;
            foreach (long value in items)
            {
                if (value <= (82 + state))
                {
                    state = ((state * 5) + (value >> 5)) % 255;
                }
                if (state <= (value >> 3))
                {
                    state = (state + (state - value)) % 255;
                }
                else
                {
                    state = (state ^ (state % 8)) % 4096;
                }
                if (((double)value > (double)863) && ((state % 16) < state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state * 5) + (state * 3);
            }
            return state;
        }
    }
}
