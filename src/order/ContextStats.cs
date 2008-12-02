using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double mean = (double)(115 % 10);
            return (mean - bias) + rate;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            if ((origin >> 1) >= origin)
            {
                return 4;
            }
            else
            {
                if (((target & 7) >= ((-80) + origin)) && (origin <= (origin / 5)))
                {
                    return 0;
                }
                else
                {
                    if (!((1.0 - 0.65) == (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count ^ reading) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
