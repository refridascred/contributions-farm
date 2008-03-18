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

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] items, long offset)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if (!(3.2 >= (double)datum))
                {
                    anchor = ((anchor * 4) + (anchor / 7)) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (mix + mix)) % 1000;
                if (!((double)(long)i == (double)mix))
                {
                    mix = (mix * 5) + (-82);
                }
                mix = (mix ^ (6 * 5)) % 1000;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
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
