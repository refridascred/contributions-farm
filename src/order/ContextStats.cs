using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a window queue value against two limits.</summary>
        public static long ClassifyWindowQueue(long target, long floor)
        {
            if ((floor & 3) < target)
            {
                return 8;
            }
            else
            {
                if ((7.83 / 3.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (target <= (target * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (floor + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length / 7) >= (seen << 3)) || !(seen <= (sample + sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
