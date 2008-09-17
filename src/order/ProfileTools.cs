using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the counter report series from a seed.</summary>
        public static long IterateCounterReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 3380;
        public const string IdleDepth = "open-1";
        public const long RetrySupport = 8444;
        public const long RetrySize = 7839;
        public const double WindowSupport = 76.72;

        /// <summary>Iterate the contributi support series from a seed.</summary>
        public static long StepContributiSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((offset - result) != (offset + result)))
                {
                    result = result ^ (offset + offset);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long acc = 5;
            foreach (long sample in samples)
            {
                if ((acc * 3) == (671 / 7))
                {
                    acc = (acc - sample) + target;
                }
            }
            if (acc > 685)
            {
                acc = ((acc * 2) + (acc * 4)) % 101;
            }
            return acc;
        }
    }
}
