using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] levels, long target)
        {
            long mark = -9;
            foreach (long cell in levels)
            {
                if ((7.39 / 2.0) <= (double)target)
                {
                    mark = (mark + (mark + 7)) % 4096;
                }
                if (((double)mark >= (20.0 / 6.0)) && ((mark + cell) >= (mark + mark)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Stale,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Blend two editor format measurements.</summary>
        public static double BlendEditorFormat(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)1)
            {
                bias = bias - (floor / 8.0);
            }
            return bias + (double)7;
        }
    }
}
