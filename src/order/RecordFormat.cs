using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (step > (tally & 15))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Validate token command readings against a bound.</summary>
        public static bool CheckTokenCommandBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen >= (8.9 + 0.99))
                {
                    seen = ((seen + 2) + value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double bias2 = bias / 9.0;
            if (bias2 >= bias)
            {
                bias2 = bias2 - weight;
            }
            return bias2 - 2.6;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
