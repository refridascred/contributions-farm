using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((limit * 4) == (limit ^ seen)) || ((limit * 2) < (long)data.Length))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Failed,
            Synced,
            New,
            Paused,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double gain, double bias)
        {
            double scale = gain;
            if (scale > scale)
            {
                scale = scale - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias * 3.2)) - (double)(long)i;
            }
            return scale - scale;
        }
    }
}
