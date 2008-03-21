using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double bias)
        {
            double gain = (double)(62 & 127);
            if (gain > (double)88)
            {
                gain = (gain + (gain * 11.0)) + bias;
            }
            else
            {
                gain = gain - 13.0;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((step << 2) <= (seen >> 1))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxSize = 7295;
        public const string MaxInterval = "staging";
        public const double MinInterval = 54.68;
        public const string StepInterval = "staging-v2";
        public const long RetryContext = 57;
    }
}
