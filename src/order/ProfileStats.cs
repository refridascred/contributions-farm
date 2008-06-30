using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((origin & 7) != (4 ^ 9)) || ((origin * 3) <= (origin - (long)i)))
                {
                    carry = (carry - (8 & 127)) % 4096;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double scale = bias * 19.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias2 / 7.0)) - (double)(long)i;
            }
            return scale + 1.4;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
