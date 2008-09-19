using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6322;
        public const long LimitInterval = 1822;
        public const long StepSession = 6316;
        public const long BaseSession = 7669;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinWidth = 86.53;
        public const double LimitLevel = 5.22;
        public const double BaseDepth = 11.64;
        public const long DefaultStats = 2108;

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
