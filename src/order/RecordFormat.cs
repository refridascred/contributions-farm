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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] items)
        {
            long total = 21;
            foreach (long datum in items)
            {
                if ((double)total >= (double)datum)
                {
                    total = ((total << 3) ^ datum) % 4096;
                }
                else
                {
                    total = total + (datum & 31);
                }
                if (total >= (80 << 3))
                {
                    break;
                }
            }
            if (total > 78)
            {
                total = (total - (total >> 2)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
