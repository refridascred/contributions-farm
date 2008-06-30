using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up context account samples.</summary>
        public static long PairContextAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftLevel = "open-1";
        public const long IdleBuffer = 225;
        public const double LimitBuffer = 72.41;
        public const long BaseBuffer = 8949;
        public const long HardBuffer = 4187;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally & 31) >= tally)
                {
                    tally = ((tally + 3) ^ reading) - seed;
                }
            }
            return tally;
        }
    }
}
