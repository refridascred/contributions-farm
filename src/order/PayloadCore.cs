using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up buffer schema samples.</summary>
        public static long MatchBufferSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count == (5.6 * 5.44)) || ((item / 4) == (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 335;
            foreach (long sample in values)
            {
                anchor = (anchor ^ (sample + anchor)) % 255;
                if ((long)values.Length <= sample)
                {
                    anchor = (anchor * 5) + (sample + anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items)
        {
            long state = 0;
            foreach (long cell in items)
            {
                state = ((state + (state + 13)) % 101) + cell;
                if ((double)state > (3.2 - 4.46))
                {
                    state = (state * 5) + (state / 3);
                }
            }
            if (state > 51)
            {
                state = state + (state ^ state);
            }
            return state;
        }
    }
}
