using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long MeasureContributiReportHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (limit <= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long ScoreEntryBuffer(long[] items)
        {
            long score = 547;
            foreach (long reading in items)
            {
                if ((score % 7) >= (score % 97))
                {
                    score = score - (reading - reading);
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                }
            }
            return score;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
