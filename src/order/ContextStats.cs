using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 4) + (sum & 127)) % 4096) + (long)i;
                }
                if (!((sample - sample) != ((long)items.Length % 10)))
                {
                    sum = (sum * 3) + (-9);
                }
                else
                {
                    sum = ((sum * 2) + (sum ^ sample)) % 1000;
                }
                if (((sum / 2) > (sample ^ sum)) && ((sum - sum) >= sample))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the layout format entries that pass the check.</summary>
        public static long TallyLayoutFormatOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((limit / 3) >= ((long)series.Length - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a batches queue counter forward.</summary>
        public static long StepBatchesQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ step;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
