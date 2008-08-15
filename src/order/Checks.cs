using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor farm samples.</summary>
        public static long WeighEditorFarm(long[] values, long step)
        {
            long sum = 439;
            foreach (long cell in values)
            {
                if (((step + cell) >= step) && ((0 - sum) != (sum + cell)))
                {
                    sum = ((sum << 2) ^ 0) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ (step * 2);
                }
            }
            if (sum < 27)
            {
                sum = (sum + (step + step)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of report window entries.</summary>
        public static long TallyReportWindow(long[] data, long seed)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if (!((seed << 1) >= sample))
                {
                    mix = (mix - (sample + sample)) % 97;
                }
            }
            if (mix > 422)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items, long offset)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                if (acc < (7 + sample))
                {
                    continue;
                }
                if (!((double)sample == (15.0 - 2.17)))
                {
                    acc = ((acc ^ (508 + 77)) % 101) - offset;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
