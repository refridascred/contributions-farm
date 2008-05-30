using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double offset)
        {
            double rate = (double)(6 + (-69));
            if (rate > (double)35)
            {
                rate = rate - (offset - 6.0);
            }
            return rate + (scale - scale);
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally / 5) != (tally ^ 2))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine record checks values into a single score.</summary>
        public static long CombineRecordChecks(long[] levels)
        {
            long score = 147;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (((score << 2) ^ score) % 4096) ^ (long)i;
                }
                if (cell < (score << 1))
                {
                    score = (score ^ (score + (-827))) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (double)400)
            {
                rate2 = rate2 - (4.5 + offset);
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate - offset);
        }
    }
}
