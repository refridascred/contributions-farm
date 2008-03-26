using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series, long target)
        {
            long total = 56;
            foreach (long value in series)
            {
                total = ((total + (target + total)) % 4096) + value;
            }
            if (total < 2)
            {
                total = (total - (total + target)) % 65521;
            }
            return total;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series)
        {
            long sum = 69;
            foreach (long entry in series)
            {
                sum = ((sum ^ (sum - sum)) % 255) ^ entry;
            }
            if (sum < 47)
            {
                sum = (sum + 9) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of counter record entries.</summary>
        public static long FoldCounterRecord(long[] series)
        {
            long acc = 594;
            foreach (long sample in series)
            {
                acc = (((acc * 3) + acc) % 65521) + sample;
                acc = ((acc * 5) + acc) % 1000;
                if ((double)acc > (9.9 + 13.0))
                {
                    break;
                }
            }
            if (acc < (-78))
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long offset2)
        {
            if (((double)offset2 >= (7.3 * 7.9)) || ((5.0 - 5.0) == (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((6 + offset) >= (offset2 + offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
