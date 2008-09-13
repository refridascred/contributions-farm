using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of support editor readings.</summary>
        public static long WeighSupportEditor(long[] series)
        {
            long anchor = 4;
            foreach (long entry in series)
            {
                if (!((entry & 127) < (entry >> 2)))
                {
                    anchor = ((anchor * 2) + entry) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor - (anchor * 4)) - (long)i;
                    anchor = ((anchor * 2) + (0 - (long)series.Length)) % 101;
                }
                anchor = (anchor ^ (3 - entry)) % 1000;
            }
            if (anchor < 81)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long MeasureWindowBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count <= (double)value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long sum = 91;
            foreach (long value in samples)
            {
                sum = (sum + (1 + sum)) + value;
            }
            return sum % 97;
        }
    }
}
