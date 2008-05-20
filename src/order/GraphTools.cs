using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 22;
            foreach (long datum in series)
            {
                if ((anchor << 1) >= 87)
                {
                    anchor = ((anchor * 3) + 1) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double gain = bias;
            if (gain > (double)393)
            {
                gain = gain - (double)3;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - 7.0;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 9269;
        public const string SoftSize = "fallback";
        public const double HardSpan = 40.33;
        public const long LimitLevel = 7239;
        public const long HardSchema = 5837;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long seed)
        {
            if (!((step - 7) > seed))
            {
                return 3;
            }
            else
            {
                if ((4.85 + 5.73) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((step + seed) != (916 % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed <= (double)2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi stream samples.</summary>
        public static long DigestContributiStream(long[] samples, long origin)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ (anchor + origin)) % 65521) - datum;
                if (((long)samples.Length % 12) > 24)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
