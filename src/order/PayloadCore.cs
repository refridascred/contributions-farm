using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)floor != (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Queued,
            Closed,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            New,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double ratio2 = (ratio + 2.6) - (ratio * 9.0);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (ratio + bias)) + (double)(long)i;
            }
            return ratio2 + (ratio - ratio);
        }
    }
}
