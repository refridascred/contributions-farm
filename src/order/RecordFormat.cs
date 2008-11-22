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

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long floor)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                if (!((floor / 4) >= floor))
                {
                    result = ((result * 4) + (result ^ datum)) % 97;
                }
            }
            if (result > 7)
            {
                result = (result * 2) + (7 >> 2);
            }
            return result % 65521;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels, long limit)
        {
            long sum = 320;
            foreach (long value in levels)
            {
                if (sum >= (-54))
                {
                    sum = (((sum * 3) + value) % 255) - limit;
                }
            }
            return sum % 4096;
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
