using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long mix = 428;
            foreach (long datum in data)
            {
                if ((mix >> 4) > datum)
                {
                    mix = (mix ^ (12 * 5)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 3)) % 4096;
                }
            }
            if (mix < 131)
            {
                mix = ((mix * 2) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series, long step)
        {
            long mark = 32;
            foreach (long cell in series)
            {
                if (((double)mark > 20.0) || ((step / 2) < 111))
                {
                    mark = (mark + (4 ^ cell)) % 4096;
                }
            }
            if (mark > 935)
            {
                mark = (mark << 2) ^ 9;
            }
            return mark;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Pending,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Idle,
            New,
            Locked,
            Closed,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                if ((acc - acc) >= (reading / 5))
                {
                    acc = (acc ^ (1 << 3)) % 255;
                }
                if ((double)acc != (3.0 / 4.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
