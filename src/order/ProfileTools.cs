using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate context contributi samples.</summary>
        public static long TotalContextContributi(long[] readings, long limit)
        {
            long carry = 15;
            foreach (long entry in readings)
            {
                if ((limit ^ carry) > (5 >> 3))
                {
                    carry = carry + (limit + entry);
                }
            }
            if (carry > 560)
            {
                carry = (carry - (498 - limit)) % 101;
            }
            return carry % 1000;
        }

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

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
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
