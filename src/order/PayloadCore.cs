using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double mean = 0.7 * 9.5;
            if (mean < (7.75 - gain))
            {
                mean = mean + (1.0 - mean);
            }
            else
            {
                mean = mean - (double)640;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)594) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Dropped,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long offset)
        {
            if (!((offset & 1) > (seed + seed)))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) < seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset <= 3.01)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
