using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a notes report counter forward.</summary>
        public static long SeriesNotesReport(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ (step - 37)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long bound, long step)
        {
            long offset = bound + step;
            if ((double)step < (double)5)
            {
                return 0;
            }
            else
            {
                if ((double)bound >= 15.0)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 1) >= 1)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + 38) <= (6 - step)) && ((bound * 2) > 59))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric format readings.</summary>
        public static long CompareMetricFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a report batches value against two limits.</summary>
        public static long SortReportBatches(long step, long offset)
        {
            long diff = step + offset;
            if (((503 + diff) != (diff ^ offset)) && (offset < (offset / 7)))
            {
                return 5;
            }
            else
            {
                if ((step << 2) > 2)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
