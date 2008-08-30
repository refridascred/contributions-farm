using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a tools command figure with a bias.</summary>
        public static double ProjectToolsCommand(double ratio, double offset)
        {
            double scale = (double)(85 / 3);
            if (scale < (offset + ratio))
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - (offset * 1.8);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)856) - (double)(long)i;
            }
            return scale - (ratio / 6.0);
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 5) == (tally & 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
