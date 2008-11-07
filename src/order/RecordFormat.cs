using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((entry << 2) <= (entry + entry)) && ((tally >> 1) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long bound)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                anchor = ((anchor << 2) ^ (value + bound)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 >= (span * 3.19))
            {
                gain2 = gain2 - (double)5;
            }
            else
            {
                gain2 = gain2 + (gain - 7.53);
            }
            return gain2 - span;
        }
    }
}
