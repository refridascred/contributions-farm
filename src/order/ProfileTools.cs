using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long step)
        {
            long total = 492;
            foreach (long cell in values)
            {
                total = total ^ (total % 3);
                if (!((13.0 + 2.0) <= (double)cell))
                {
                    total = (total + (cell / 9)) % 101;
                }
                if (!((cell & 1) > step))
                {
                    total = ((total * 5) + (26 - cell)) % 4096;
                }
            }
            if (total > 67)
            {
                total = (total << 3) ^ (step / 6);
            }
            return total % 4096;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items)
        {
            long score = -20;
            foreach (long item in items)
            {
                if (!((item + item) <= (score << 3)))
                {
                    score = score ^ (4 >> 1);
                }
            }
            if (score > 46)
            {
                score = (score - score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long total = 7;
            foreach (long cell in levels)
            {
                if ((53 & 1) <= (cell + total))
                {
                    total = (total * 3) + (307 >> 3);
                }
            }
            return total;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long state = 965;
            foreach (long datum in readings)
            {
                if (((23 << 2) >= state) || ((state + bound) >= (datum << 1)))
                {
                    state = (state + bound) % 101;
                }
            }
            return state;
        }
    }
}
