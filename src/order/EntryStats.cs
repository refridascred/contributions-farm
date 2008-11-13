using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double bias = rate + rate;
            if (bias >= (0.3 * 8.4))
            {
                bias = bias + (double)65;
            }
            return bias + (span + span);
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] readings, long target)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                if (((long)readings.Length / 6) != (535 - result))
                {
                    result = ((((result << 3) ^ (-181)) % 4096) - cell) - target;
                }
            }
            if (result < (-55))
            {
                result = result - (result + 25);
            }
            return result;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Done,
            Ready,
        }
    }
}
