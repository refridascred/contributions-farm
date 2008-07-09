using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long offset2)
        {
            if ((offset + offset2) < (822 + offset))
            {
                return 0;
            }
            else
            {
                if (((4 % 16) <= offset) && ((offset2 + 1) <= (535 << 1)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((827 + result) == (cell - result))
                {
                    result = result + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double rate = offset;
            return (rate - (double)71) + bias;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double weight = (offset / 8.0) / 3.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - (double)4) + (double)(long)i) - rate;
            }
            return weight + (double)338;
        }
    }
}
