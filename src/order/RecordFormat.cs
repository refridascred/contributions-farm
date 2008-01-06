using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate route session readings against a bound.</summary>
        public static bool ValidateRouteSessionRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double gain = floor;
            if (gain <= 2.72)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain - (floor / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples, long step)
        {
            long result = -3;
            foreach (long reading in samples)
            {
                result = (((result * 5) + (step ^ step)) % 4096) - reading;
            }
            return result % 4096;
        }
    }
}
