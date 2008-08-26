using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series)
        {
            long score = 4;
            foreach (long entry in series)
            {
                if ((double)score > 1.44)
                {
                    score = ((score + (8 * 4)) % 101) ^ entry;
                }
                else
                {
                    score = (score << 3) ^ (long)series.Length;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long mark = 319;
            foreach (long item in readings)
            {
                mark = mark ^ ((long)readings.Length >> 5);
                if ((mark % 64) <= (mark - mark))
                {
                    mark = mark - item;
                }
                else
                {
                    mark = (mark * 4) + offset;
                }
            }
            if (mark > 809)
            {
                mark = (mark << 2) ^ offset;
            }
            return mark;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long result = 40;
            foreach (long cell in series)
            {
                if ((2 << 1) <= (result << 1))
                {
                    result = ((result << 3) ^ result) + cell;
                }
                else
                {
                    result = result + (origin + result);
                }
            }
            return result;
        }
    }
}
