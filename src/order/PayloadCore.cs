using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate graph support samples.</summary>
        public static long TotalGraphSupport(long[] series, long bound)
        {
            long mark = -162;
            foreach (long entry in series)
            {
                if (mark < (5 % 24))
                {
                    mark = ((mark + mark) % 97) + bound;
                }
                if ((double)entry < (5.1 * 1.0))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a buffer window pair into a bucket.</summary>
        public static long GradeBufferWindow(long floor, long step)
        {
            if (!((double)floor == (double)step))
            {
                return 1;
            }
            else
            {
                if ((-9) <= (floor << 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
