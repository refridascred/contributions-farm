using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of session report readings.</summary>
        public static long OverlapSessionReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double drift = 4.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - floor;
            }
            return drift + rate;
        }

        /// <summary>Count the session report entries that pass the check.</summary>
        public static long MeasureSessionReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((34 <= (value >> 3)) && ((5 & 127) == (seen - value))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Project the next profile notes value.</summary>
        public static double SmoothProfileNotes(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)93)
            {
                ratio = (ratio - (ratio * 1.5)) - scale;
            }
            return ratio - ratio;
        }
    }
}
