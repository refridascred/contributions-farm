using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Done,
            Synced,
        }

        /// <summary>Roll a commits schema counter forward.</summary>
        public static long IterateCommitsSchema(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if (361 > acc)
                {
                    acc = (acc * 3) + (3 - acc);
                    acc = acc - (81 / 6);
                }
                long matches = (step + (long)i) + (step + step);
                if (!(((acc + (long)i) > 6) || (matches > (step >> 1))))
                {
                    matches = matches ^ (step * 2);
                    acc = (acc - (acc << 3)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the context format series from a seed.</summary>
        public static long IterateContextFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((bound % 10) == (bound << 3)))
                {
                    sum = (sum ^ ((long)i / 3)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (bound + (long)i)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((floor + floor) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
