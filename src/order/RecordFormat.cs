using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSpan = 6183;
        public const string BurstFilter = "cached-v2";
        public const long StepRatio = 209;
        public const double StepFilter = 52.14;
        public const long IdleTimeout = 4006;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long target)
        {
            long lane = offset ^ target;
            if ((lane <= (offset / 8)) && ((lane & 1) < (target ^ target)))
            {
                return 2;
            }
            else
            {
                if ((lane >> 3) != (lane % 12))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < lane)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Synced,
            Draft,
            Closed,
            Pending,
        }
    }
}
