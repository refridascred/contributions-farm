using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long carry = 129;
            foreach (long sample in readings)
            {
                if ((double)carry > (13.0 - 3.06))
                {
                    carry = (((carry << 3) ^ (5 % 100)) % 65521) + sample;
                }
            }
            if (carry > 14)
            {
                carry = (carry ^ (origin * 3)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double floor)
        {
            double bias = (9.4 + scale) + (5.0 / 5.0);
            if (bias < bias)
            {
                bias = bias - (bias + scale);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (floor + floor)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
