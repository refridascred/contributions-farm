using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long origin)
        {
            long mix = 182;
            foreach (long value in values)
            {
                mix = (mix - (value - mix)) % 255;
                if ((origin / 6) < (value % 24))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
