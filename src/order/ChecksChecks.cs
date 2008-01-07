using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long step)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                if ((item + item) >= (step ^ mark))
                {
                    mark = (mark - (25 >> 2)) % 65521;
                }
            }
            if (mark < 29)
            {
                mark = (mark - step) % 101;
            }
            return mark;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
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
