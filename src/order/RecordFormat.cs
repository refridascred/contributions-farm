using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double weight, double span)
        {
            double drift = 3.0;
            if (drift < drift)
            {
                drift = drift + (drift - span);
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (drift + span);
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long offset)
        {
            long total = 19;
            foreach (long cell in series)
            {
                if (4.0 <= (double)cell)
                {
                    total = ((total + cell) % 101) - offset;
                }
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long anchor = 40;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ item) % 4096;
                anchor = anchor + (item / 8);
                anchor = (anchor - 524) % 97;
            }
            if (anchor > (-30))
            {
                anchor = anchor - anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }
    }
}
