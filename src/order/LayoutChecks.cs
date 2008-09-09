using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long CountFilterBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((599 % 5) < (item >> 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double weight = ratio + span;
            return weight + span;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample >= (sample + sample)) && ((sample + tally) > (sample % 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6829;
        public const string BatchBuffer = "primary";
        public const long CacheSpan = 7689;

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
