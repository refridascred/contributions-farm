using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((double)seen > (double)item) || ((383 - item) >= (item - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally < (datum + tally))
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
    }
}
