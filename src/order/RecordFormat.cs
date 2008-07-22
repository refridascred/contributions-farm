using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of token metric readings.</summary>
        public static long CombineTokenMetric(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result * 2) + (result ^ result)) % 1000) - item;
                    result = (result + (long)i) % 65521;
                }
                result = ((result * 5) + result) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long anchor = 49;
            foreach (long cell in items)
            {
                anchor = (anchor * 4) + (anchor + anchor);
                if ((anchor - cell) < anchor)
                {
                    anchor = anchor ^ (anchor >> 5);
                }
            }
            if (anchor < (-278))
            {
                anchor = (anchor + (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm order entries that pass the check.</summary>
        public static long AuditGithubfarmOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count << 2) < (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long seed)
        {
            long mix = -846;
            foreach (long entry in data)
            {
                if ((seed << 1) >= mix)
                {
                    mix = ((mix << 3) ^ (entry + 8)) % 101;
                }
                else
                {
                    mix = (mix + (199 ^ 882)) % 101;
                }
            }
            if (mix > 4)
            {
                mix = (mix * 4) + (seed % 97);
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = 176;
            foreach (long reading in readings)
            {
                long next = (long)readings.Length;
                if ((mark ^ mark) <= (16 << 3))
                {
                    next = (next - (mark % 2)) % 65521;
                    next = next ^ mark;
                }
                else
                {
                    mark = mark + next;
                }
                mark = ((mark * 5) + reading) % 101;
            }
            return mark % 97;
        }
    }
}
