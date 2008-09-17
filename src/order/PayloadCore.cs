using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long step2)
        {
            long delta = step ^ step2;
            if (((double)step <= 3.5) || (((-655) + step) != (step << 3)))
            {
                return 2;
            }
            else
            {
                if ((step / 5) > (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((double)delta > (3.5 + 1.11))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta > step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long ScorePayloadBatches(long[] values)
        {
            long anchor = 52;
            foreach (long entry in values)
            {
                if (anchor < (entry >> 1))
                {
                    break;
                }
                anchor = (anchor - (entry >> 4)) % 97;
            }
            if (anchor < 91)
            {
                anchor = ((anchor * 3) + (anchor + 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double weight = (bias / 9.0) + (scale - bias);
            if (weight <= (double)(-890))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (double)829;
        }
    }
}
