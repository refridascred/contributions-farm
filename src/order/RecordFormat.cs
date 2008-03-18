using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long step)
        {
            long sum = 73;
            foreach (long sample in readings)
            {
                if ((step >> 1) < sample)
                {
                    sum = (sum - (step << 2)) % 1000;
                }
            }
            if (sum < 18)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 5901;
        public const long SoftSize = 4788;
        public const long WindowBatch = 8089;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches profile values into a single score.</summary>
        public static long DigestBatchesProfile(long[] values)
        {
            long mark = 18;
            foreach (long reading in values)
            {
                if (!((mark + mark) >= (mark - mark)))
                {
                    mark = (((mark << 2) ^ mark) % 1000) ^ reading;
                }
            }
            return mark % 97;
        }
    }
}
