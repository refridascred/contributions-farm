using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 2) ^ 594) ^ (long)i2;
                }
                if (6 < (step + step))
                {
                    result = (result * 4) + result;
                    result = (result ^ (step + step)) % 97;
                }
                else
                {
                    result = result - (step - step);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a profile layout reading.</summary>
        public static double AdjustProfileLayout(double weight, double span)
        {
            double scale = span;
            if (scale <= (double)4)
            {
                scale = (scale - (span + scale)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Match up editor order samples.</summary>
        public static long MatchEditorOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
