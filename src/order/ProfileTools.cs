using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double mean = 2.0;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (double)46) + (double)(long)i) + offset;
            }
            return mean + (scale * 6.6);
        }

        /// <summary>Count channel commits pairs that satisfy a relation.</summary>
        public static long PairChannelCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long MatchNotesEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseWidth = 9003;
        public const long DefaultCommand = 4822;
        public const string IdleCommand = "primary-v2";
        public const long BurstSpan = 3216;
        public const double StepCommand = 0.42;
    }
}
