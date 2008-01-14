using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate githubfarm context readings against a bound.</summary>
        public static bool GuardGithubfarmContextBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the order payload entries that pass the check.</summary>
        public static long TallyOrderPayloadOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((7.0 + 1.24) < (double)value))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long MeasureChannelReportOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum * 4) < (target * 4)) && ((target / 4) <= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
