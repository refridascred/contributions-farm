using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((5.2 / 3.0) >= (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long step, long origin)
        {
            long span = step ^ origin;
            if (274 >= span)
            {
                return 2;
            }
            else
            {
                if (!(9 < origin))
                {
                    return 5;
                }
                else
                {
                    if ((step << 3) < (origin % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
